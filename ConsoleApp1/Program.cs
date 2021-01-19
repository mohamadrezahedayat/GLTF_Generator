using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLTF_Generator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cube1 = GltfGenerator.createCubeRectangles(5, 5, 5);
            var cube2 = GltfGenerator.createCubeRectangles(5, 5, 5, 6, 0, 0);
            var cube3 = GltfGenerator.createCubeRectangles(5, 5, 5, 6, 6, 0);
            var cube4 = GltfGenerator.createCubeRectangles(5, 5, 5, 6, 6, -6);
            var cube5 = GltfGenerator.createCubeRectangles(5, 5, 5, 6, 12, 0);
            var trs = new List<Triangle>();
            //trs.AddRange(cube1);
            trs.AddRange(cube2);
            trs.AddRange(cube3);
            trs.AddRange(cube4);
            trs.AddRange(cube5);
            var mesh = new Mesh(trs);
            var rand = new Random();
            var basecolorFactor = new float[] { (float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble() };
            var pbrMetallicRoughness = new pbrMetallicRoughness(basecolorFactor, (float)rand.NextDouble(), (float)rand.NextDouble());
            var material = new Material(pbrMetallicRoughness, true, "mat1");
            mesh.Material = material;

            var node = new Node(mesh);

            var cube6 = GltfGenerator.createCubeRectangles(4.5f, 4.5f, 4.5f);
            var cube7 = GltfGenerator.createCubeRectangles(4.5f, 4.5f, 4.5f, 20, 0, 0);
            var cube8 = GltfGenerator.createCubeRectangles(4.5f, 4.5f, 4.5f, 20, 20, 0);
            var cube9 = GltfGenerator.createCubeRectangles(4.5f, 4.5f, 4.5f, 20, 20, -20);
            var cube10 = GltfGenerator.createCubeRectangles(4.5f, 4.5f, 4.5f, 20, 26, 0);
            var trs2 = new List<Triangle>();
            trs2.AddRange(cube6);
            trs2.AddRange(cube7);
            trs2.AddRange(cube8);
            trs2.AddRange(cube9);
            trs2.AddRange(cube10);
            var mesh2 = new Mesh(trs2);
            var basecolorFactor2 = new float[] { (float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble(), (float)rand.NextDouble() };
            var pbrMetallicRoughness2 = new pbrMetallicRoughness(basecolorFactor2, (float)rand.NextDouble(), (float)rand.NextDouble());
            var material2 = new Material(pbrMetallicRoughness2, true, "mat2");
            mesh2.Material = material2;
            var node2 = new Node(mesh2);

            var gltf = new GltfGenerator();
            gltf.Scene.Nodes.Add(node);
            gltf.Scene.Nodes.Add(node2);
            var s = gltf.createGltf();
            var d = s;

        }
    }
}
