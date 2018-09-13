using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Klaster.Klasterization
{
    public class KlasterProcessing
    {
        private List<List<int>> _equalLabels;
        private int[,] labels;
        private int currentLabel;
        private int[,] tempBorders;

        public KlasterProcessing()
        {
            this._equalLabels = new List<List<int>>();
        }

        public IList<PropertiesOfObject> CreateListOfObjects(bool[,] originMatrix)
        {
            var unicumLabels = new List<int>();
            var listOfObjects = new List<PropertiesOfObject>();

            var source = this.Labeling(originMatrix);

            for (var y = 0; y < source.GetLength(0); ++y)
            {
                for (var x = 0; x < source.GetLength(1); ++x)
                {
                    if (source[y, x] != 0 && !unicumLabels.Contains(source[y, x]))
                    {
                        unicumLabels.Add(source[y, x]);
                    }
                }
            }

            foreach (var label in unicumLabels)
            {
                var squere = this.Squere(source, label);
                var perimeter = this.Perimeter(source, label);
                var compactness = this.Compactness(squere, perimeter);

                var obj = new PropertiesOfObject(squere, perimeter, compactness);
                listOfObjects.Add(obj);
            }

            return listOfObjects;
        }

        public List<List<PropertiesOfObject>> DivideOnKlastersAsync(int countOfClasters, IList<PropertiesOfObject> vectors)
        {
            return Task.Run(() =>
            {
                var klasters = new IList<PropertiesOfObject>[countOfClasters];
                this.Initialize(ref klasters);
                IEnumerable<PropertiesOfObject> medoids = null;
                var listOfDistances = new List<IList<double>>();
                double minSum = double.MaxValue;
                var iterations = Math.Pow(countOfClasters, vectors.Count);

                for (var i = 0; i < iterations; ++i)
                {
                    listOfDistances.Clear();
                    medoids = this.ChooseMedoids(countOfClasters, vectors.Count() - 1, vectors);

                    foreach (var item in vectors)
                    {
                        listOfDistances.Add(medoids.Select(med => this.CalculateDistance(item, med)).ToList());
                    }

                    var sum = listOfDistances.Select(item => item.Min()).Sum();
                    if (sum < minSum)
                    {
                        this.Initialize(ref klasters);
                        minSum = sum;
                        foreach (var distances in listOfDistances)
                        {
                            var indexOfKlaster = distances.IndexOf(distances.Min());
                            klasters[indexOfKlaster].Add(vectors[listOfDistances.IndexOf(distances)]);
                        }
                    }
                }

                return klasters.Cast<List<PropertiesOfObject>>().ToList();
            }).Result;
        }

        public void Clear()
        {
            foreach(var item in this._equalLabels)
            {
                item.Clear();
            }
            this._equalLabels.Clear();

            this.currentLabel = 0;
        }

        private void Initialize(ref IList<PropertiesOfObject>[] source)
        {
            for (var i = 0; i < source.Length; ++i)
            {
                source[i] = new List<PropertiesOfObject>();
            }
        }

        private double CalculateDistance(PropertiesOfObject obj1, PropertiesOfObject obj2)
        {
            var dX = Math.Abs(obj1.NormalizedSquere - obj2.NormalizedSquere);
            var dY = Math.Abs(obj1.NormalizedPerimeter - obj2.NormalizedPerimeter);
            var dZ = Math.Abs(obj1.NormalizedCompactness - obj2.NormalizedCompactness);

            return Math.Pow(Math.Pow(dZ, 2) + Math.Pow(Math.Pow(dX, 2) + Math.Pow(dY, 2), 0.5) , 0.5);
        }

        private IEnumerable<PropertiesOfObject> ChooseMedoids(int count, int maxVal, IEnumerable<PropertiesOfObject> source)
        {
            var used = new List<int>();
            var medoids = new List<PropertiesOfObject>();
            var random = new Random();

            for (var i = 0; i < count; ++i)
            {
                int index;
                do
                {
                    index = random.Next(0, maxVal);
                } while (used.Contains(index));

                used.Add(index);
                medoids.Add(source.ElementAt(index));
            }

            return medoids;
        }

        private int[,] Labeling(bool[,] matrix)
        {
            this.currentLabel = 1;
            this.labels = new int[matrix.GetLength(0), matrix.GetLength(1)];
            labels.Initialize();

            for (var j = 0; j < matrix.GetLength(0); ++j)
            {
                for (var i = 0; i < matrix.GetLength(1); ++i)
                {
                    if (matrix[j, i])
                    {
                        this.UpdateLabels(i, j);
                    }
                    else
                    {
                        labels[j, i] = 0;
                    }
                }
            }

            this.ResolveEquals();

            return this.labels;
        }

        private void ResolveEquals()
        {
            this._equalLabels = this._equalLabels.Select(item => item.Distinct().ToList()).ToList();

            for (var j = 0; j < this.labels.GetLength(0); ++j)
            {
                for (var i = 0; i < this.labels.GetLength(1); ++i)
                {
                    if (this.labels[j, i] != 0 && this._equalLabels.Any(item => item.Contains(this.labels[j, i])))
                    {
                        this.labels[j, i] = this._equalLabels.First(item => item.Contains(this.labels[j, i])).First();
                    }
                }
            }
        }

        private void UpdateLabels(int x, int y)
        {
            if (x - 1 < 0 && y - 1 < 0)
            {
                this.labels[y, x] = this.currentLabel;
            }
            else if (x - 1 < 0)
            {
                this.labels[y, x] = this.labels[y - 1, x] != 0 ?
                    this.labels[y - 1, x] :
                    this.labels[y, x] = ++this.currentLabel;
            }
            else if (y - 1 < 0)
            {
                this.labels[y, x] = this.labels[y, x - 1] != 0 ?
                    this.labels[y, x] = this.labels[y, x - 1] :
                    this.labels[y, x] = ++this.currentLabel;
            }
            else
            {
                if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] != 0 && this.labels[y - 1, x] != this.labels[y, x - 1])
                {
                    this.labels[y, x] = this.labels[y - 1, x];
                    if (this._equalLabels.Any(item => item.Contains(this.labels[y - 1, x])))
                    {
                        var index = this._equalLabels.IndexOf(this._equalLabels.First(item => item.Contains(this.labels[y - 1, x])));
                        this._equalLabels[index].Add(this.labels[y, x - 1]);
                    }
                    else
                    {
                        this._equalLabels.Add(new List<int>() { this.labels[y - 1, x], this.labels[y, x - 1] });
                    }
                }
                else if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] != 0 && this.labels[y - 1, x] == this.labels[y, x - 1])
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                }
                else if (this.labels[y - 1, x] == 0 && this.labels[y, x - 1] != 0)
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                }
                else if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] == 0)
                {
                    this.labels[y, x] = this.labels[y - 1, x];
                }
                else
                {
                    this.labels[y, x] = ++this.currentLabel;
                }
            }
        }

        private int Squere(int[,] source, int label)
        {
            return source.Cast<int>().Count(item => item == label);
        }

        private int Perimeter(int[,] source, int label)
        {
            if (this.tempBorders == null)
            {
                this.tempBorders = new int[source.GetLength(0), source.GetLength(1)];
                this.tempBorders.Initialize();

                for (var j = 0; j < source.GetLength(0); ++j)
                {
                    for (var i = 0; i < source.GetLength(1); ++i)
                    {
                        if (source[j, i] != 0)
                        {
                            if (j - 1 < 0 ||
                                i - 1 < 0 ||
                                j + 1 >= source.GetLength(0) ||
                                i + 1 >= source.GetLength(1) ||
                                source[j - 1, i] == 0 ||
                                source[j, i + 1] == 0 ||
                                source[j + 1, i] == 0 ||
                                source[j, i - 1] == 0)
                            {
                                this.tempBorders[j, i] = source[j, i];
                            }
                            else
                            {
                                this.tempBorders[j, i] = 0;
                            }
                        }
                    }
                }
            }

            return this.Squere(this.tempBorders, label);
        }

        private double Compactness(float squere, float perimeter)
        {
            return Math.Pow(perimeter, 2) / squere;
        }
    }
}