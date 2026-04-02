using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProcessamentoImagens.classes
{
    internal class Poligono
    {
        private List<Reta> Arestas { get; set; }
        private double[,] MatrizTransformacao { get; set; }

        public Poligono()
        {
            Arestas = new List<Reta>();
            MatrizTransformacao = new double[3, 3];

            GerarMatrizIdentidade();
        }

        public Reta GetAresta(int pos)
        {
            if (pos > -1 && pos < Arestas.Count)
                return Arestas[pos];
            return null;
        }

        public void AddAresta(Reta r)
        {
            Arestas.Add(r);
        }

        public void ClearPoligono()
        {
            Arestas.Clear();
        }

        public int CountArestas()
        {
            return Arestas.Count;
        }

        private void GerarMatrizIdentidade()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (i == j)
                        MatrizTransformacao[i, j] = 1;
                    else
                        MatrizTransformacao[i, j] = 0;
            /*
            1 0 0
            0 1 0
            0 0 1
            */
        }

        public Double? GetMatrizXY(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < 3 && y < 3)
                return MatrizTransformacao[x, y];
            return null;
        }

        public void SetMatrizXY(int x, int y, double valor)
        {
            if (x > -1 && x < 3 && y > -1 && y < 3)
                MatrizTransformacao[x, y] = valor;
        }

        public override string ToString()
        {
            string retorno = $"{Arestas.Count}";
            for (int i = 0; i < Arestas.Count; i++)
            {
                retorno += $"|{Arestas[i].GetIniX()},{Arestas[i].GetIniY()}|{Arestas[i].GetFimX()},{Arestas[i].GetFimY()}";
            }
            return retorno;
        }

        public List<Reta> GetArestasTransformadas()
        {
            List<Reta> arestasTransformadas = new List<Reta>();
            List<Point> vertices = GetVertices();
            List<Point> novosVertices = new List<Point>();
            Point vertice1, vertice2;

            //multiplicar os vértices pela matriz de tranformação e retornar o valor já calculado
            for (int i = 0; i < vertices.Count; i++)
                novosVertices.Add(MultiplicaVerticeMatriz(vertices[i]));

            //ajustar os vértices das novas arestas
            vertice1 = novosVertices[0];
            for (int i = 1; i < novosVertices.Count; i++)
            {
                vertice2 = novosVertices[i];
                arestasTransformadas.Add(new Reta(vertice1, vertice2));
                vertice1 = vertice2;
            }
            vertice2 = novosVertices[0];
            arestasTransformadas.Add(new Reta(vertice1, vertice2)); //última aresta de fechamento

            return arestasTransformadas;
        }

        public Point MultiplicaVerticeMatriz(Point vertice)
        {
            double valor = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    valor = MatrizTransformacao[l, c] * vertice.X;
                    valor += MatrizTransformacao[l, c] * vertice.Y;
                    valor += MatrizTransformacao[l, c] * 1;
                }
                if (l == 0)//linha da matriz que representa x
                    vertice.X = (int)valor;
                if (l == 1)
                    vertice.Y = (int)valor;
            }
            return vertice;
        }

        public List<Point> GetVertices()
        {
            List<Point> vertices = new List<Point>();

            for (int i = 0; i < Arestas.Count; i++)
                vertices.Add(new Point(Arestas[i].GetIniX(), Arestas[i].GetIniY()));

            return vertices;
        }

        public void MultiplicaMatrizEscala(double escalaX, double escalaY)
        {
            /*
            sx -> escalaX
            sy -> escalaY
            sx 0  0
            0  sy 0
            0  0  1
            */
            double valor = 0;
            double[,] matrizEscala = new double[3, 3] {
                { escalaX, 0, 0 },
                { 0, escalaY, 0 },
                { 0, 0, 1 } };
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        valor = MatrizTransformacao[l, i] * matrizEscala[i, c];
                        valor += MatrizTransformacao[l, i] * matrizEscala[i, c];
                        valor += MatrizTransformacao[l, i] * matrizEscala[i, c];
                    }

                    //setar na matriz
                    SetMatrizXY(l, c, valor);
                }
            }
        }

        public void MultiplicaMatrizTranslacao(double tX, double tY)
        {
            double valor = 0;
            double[,] matrizTranslacao = new double[3, 3] {
                { 1, 0, tX },
                { 0, 1, tY },
                { 0, 0, 1 }
            };

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        valor = MatrizTransformacao[l, i] * matrizTranslacao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizTranslacao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizTranslacao[i, c];
                    }

                    //setar na matriz
                    SetMatrizXY(l, c, valor);
                }
            }
        }

        public void MultiplicaMatrizCisalhamento(double cisalhamentoX, double cisalhamentoY)
        {
            /*
            b -> cisalhamentoX
            a -> cisalhamentoY
            */
            double valor = 0;
            double[,] matrizCisalhamento = new double[3, 3] {
                { 1, cisalhamentoX, 0 },
                { cisalhamentoY, 1, 0 },
                { 0, 0, 1 }
            };
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        valor = MatrizTransformacao[l, i] * matrizCisalhamento[i, c];
                        valor += MatrizTransformacao[l, i] * matrizCisalhamento[i, c];
                        valor += MatrizTransformacao[l, i] * matrizCisalhamento[i, c];
                    }

                    //setar na matriz
                    SetMatrizXY(l, c, valor);
                }
            }
        }

        public void MultiplicaMatrizReflexao(bool reflexaoX, bool reflexaoY)
        {            /*
            em Y : -1  0  0   
                    0  1  0
                    0  0  1

            em X :  1  0  0
                    0 -1  0
                    0  0  1
            */
            double valor = 0;
            double[,] matrizReflexao = new double[3, 3] {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
                };

            if (reflexaoX && reflexaoY)
            {
                matrizReflexao[0,0] = -1;
                matrizReflexao[1,1] = -1;
            }
            else if (reflexaoX)
                matrizReflexao[1,1] = -1;
            else if (reflexaoY)
                matrizReflexao[0,0] = -1;

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        valor = MatrizTransformacao[l, i] * matrizReflexao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizReflexao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizReflexao[i, c];
                    }

                    //setar na matriz
                    SetMatrizXY(l, c, valor);
                }
            }
        }

        public void MultiplicaMatrizRotacao(int grau)
        {
            /*
            cos()  -sen()  0
            sen()  cos()   0
            0       0      1
            */
            double cosseno = Math.Cos(grau * Math.PI/180);
            double seno = Math.Sin(grau * Math.PI/180);
            double valor = 0;
            double[,] matrizRotacao = new double[3, 3] {
                { cosseno, -seno, 0 },
                { seno, cosseno, 0 },
                { 0, 0, 1 }
            };
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        valor = MatrizTransformacao[l, i] * matrizRotacao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizRotacao[i, c];
                        valor += MatrizTransformacao[l, i] * matrizRotacao[i, c];
                    }

                    //setar na matriz
                    SetMatrizXY(l, c, valor);
                }
            }
        }
    }
}
