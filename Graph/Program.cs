using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Graph
{
    class Vertex
    {
        public char label;
        public Boolean visited;
        public Vertex(char lab)
        {
            this.label = lab;
            this.visited = false;
        }
    }
    class Graph
    {
        int maxVertices = 20;
        Vertex[] vertexList;
        int[][] adjMatrix;
        int vertexcount;
        Queue thequeue;
        
        public Graph(){
            vertexList = new Vertex[maxVertices];
            adjMatrix=new int[maxVertices][];
           vertexcount=0;
            thequeue=new Queue();
        }

        public void addvertex(char lab)
        {
            vertexList[vertexcount++] = new Vertex(lab);
        }
        public void addEdge(int start, int end)
        {
            adjMatrix[start][end] = 1;
            adjMatrix[end][start] = 1;
        }

        public void bfs()
        {
            vertexList[0].visited = true;
            thequeue.Enqueue(0);
            //display 0 vertex lalbel
            int v2;
            while (thequeue.Count > 0)
            {
                int v1 = (int)thequeue.Dequeue();
                while ((v2 = getAdjaUnvisited(v1)) != -1)
                {
                    vertexList[v2].visited = true;
                    //display
                    thequeue.Enqueue(v2);
                }


            }
            // make all the vertices to visited false
        }
        public int getAdjaUnvisited(int v)
        {
            for (int j = 0; j < vertexcount; j++)
            {
                if (adjMatrix[v][j] == 1 && vertexList[j].visited == false)
                {
                    return j;
                }
            }
            return -1;
        }
    }

    class binartree
    {
        int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        binartree left;

        internal binartree Left
        {
            get { return left; }
            set { left = value; }
        }
        binartree right;

        internal binartree Right
        {
            get { return right; }
            set { right = value; }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            Queue q = new Queue();
            
        }
    }
}
