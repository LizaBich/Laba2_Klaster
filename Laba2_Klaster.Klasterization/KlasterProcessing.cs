using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Klaster.Klasterization
{
    public class KlasterProcessing
    {
        private IList<IList<int>> _equalLabels;
        private int[,] labels;
        private int currentLabel;

        public KlasterProcessing()
        {
            this._equalLabels = new List<IList<int>>();
        }

        public int[,] Labeling(bool[,] matrix)
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
                    } else
                    {
                        labels[j, i] = 0;
                    }
                }
            }

            this.ResolveEquals();

            return this.labels;
        }

        private void UpdateLabels(int x, int y)
        {
            if (x - 1 < 0 && y - 1 < 0)
            {
                this.labels[y, x] = this.currentLabel;
                this._equalLabels.Add(new List<int>() { this.currentLabel });
            } else if (x - 1 < 0) {
                if (this.labels[y - 1, x] != 0)
                {
                    this.labels[y, x] = this.labels[y - 1, x];
                } else
                {
                    this.labels[y, x] = ++this.currentLabel;
                    this._equalLabels.Add(new List<int> { this.currentLabel });
                }
            } else if (y - 1 < 0)
            {
                if (this.labels[y, x - 1] != 0)
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                } else
                {
                    this.labels[y, x] = ++this.currentLabel;
                    this._equalLabels.Add(new List<int> { this.currentLabel });
                }
            } else
            {
                if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] != 0 && this.labels[y - 1, x] != this.labels[y, x - 1])
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                    this._equalLabels.FirstOrDefault(item => item.Contains(this.labels[y, x - 1])).ToList().Add(this.labels[y - 1, x]);
                } else if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] != 0 && this.labels[y - 1, x] == this.labels[y, x - 1])
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                } else if (this.labels[y - 1, x] == 0 && this.labels[y, x - 1] != 0)
                {
                    this.labels[y, x] = this.labels[y, x - 1];
                }
                else if (this.labels[y - 1, x] != 0 && this.labels[y, x - 1] == 0)
                {
                    this.labels[y, x] = this.labels[y - 1, x];
                } else
                {
                    this.labels[y, x] = ++this.currentLabel;
                    this._equalLabels.Add(new List<int>() { this.currentLabel });
                }
            }
        }

        private void ResolveEquals()
        {
            for (var j = 0; j < this.labels.GetLength(0); ++j)
            {
                for (var i = 0; i < this.labels.GetLength(1); ++i)
                {
                    if (this.labels[j, i] != 0)
                    {
                        this.labels[j, i] = this._equalLabels.FirstOrDefault(item => item.Contains(this.labels[j, i])).First();
                    }
                }
            }
        }
    }
}
