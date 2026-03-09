using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProcessamentoImagens.classes
{
    internal class Poligono
    {
        private List<Point> vertices { get; set; }
        private double[,] matrizTransformacao { get; set; }

        public Poligono()
        {
            vertices = new List<Point>();
            matrizTransformacao = new double[3, 3];

            GerarMatrizIdentidade();
        }


        private void GerarMatrizIdentidade()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (i == j)
                        matrizTransformacao[i, j] = 1;
                    else
                        matrizTransformacao[i, j] = 0;
        }

        private Point? GetVertice(int pos)
        {
            if(pos>=0 && pos < vertices.Count)
                return vertices[pos];
            return null;
        }

        private Double? GetMatrizXY(int x,int y)
        {
            if(x>=0 && y>=0 && x<3 && y < 3)
                return matrizTransformacao[x, y];
            return null;
        }
    }
}
