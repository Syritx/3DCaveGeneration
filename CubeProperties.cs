using OpenTK.Mathematics;
using System.Collections.Generic;

namespace _3d {
    class CubeProperties {

        public static float[] vertices = {

        //   X  Y  Z  R G B
            -1,-1,-1, 0,1,0, // 0
            -1, 1,-1, 0,1,0, // 1
             1, 1,-1, 0,1,0, // 2
             1,-1,-1, 0,1,0, // 3

            -1,-1, 1, 0,1,0, // 4
            -1, 1, 1, 0,1,0, // 5
             1, 1, 1, 0,1,0, // 6
             1,-1, 1, 0,1,0, // 7
        };
        public static uint[] indices = {
            1, 2, 3, // front
            3, 0, 1, // front

            5, 6, 7, // back
            7, 4, 5, // back

            1, 5, 4, // left
            4, 0, 1, // left

            2, 6, 7, // right
            7, 3, 2, // right

            1, 2, 6, // top
            6, 5, 1, // top

            0, 3, 7, // bottom
            7, 4, 0, // bottom
        };

        public static List<float> GetPositionedVertices(Vector3 position, List<float> currentVertices) {
            float[] verts = {
                -1+position.X,-1+position.Y,-1+position.Z, 0,1,0, // 0
                -1+position.X, 1+position.Y,-1+position.Z, 0,0,1, // 1
                 1+position.X, 1+position.Y,-1+position.Z, 0,0,1, // 2
                 1+position.X,-1+position.Y,-1+position.Z, 0,1,0, // 3

                -1+position.X,-1+position.Y, 1+position.Z, 0,1,0, // 4
                -1+position.X, 1+position.Y, 1+position.Z, 0,0,1, // 5
                 1+position.X, 1+position.Y, 1+position.Z, 0,0,1, // 6
                 1+position.X,-1+position.Y, 1+position.Z, 0,1,0, // 7
            };

            foreach(float a in verts) {
                currentVertices.Add(a);
            }

            return currentVertices;
        }

        public static List<uint> GetNewIndices(uint position, List<uint> currentIndices) {
            uint[] inds = {
                1+(8*position), 2+(8*position), 3+(8*position), // front
                3+(8*position), 0+(8*position), 1+(8*position), // front

                5+(8*position), 6+(8*position), 7+(8*position), // back
                7+(8*position), 4+(8*position), 5+(8*position), // back

                1+(8*position), 5+(8*position), 4+(8*position), // left
                4+(8*position), 0+(8*position), 1+(8*position), // left

                2+(8*position), 6+(8*position), 7+(8*position), // right
                7+(8*position), 3+(8*position), 2+(8*position), // right

                1+(8*position), 2+(8*position), 6+(8*position), // top
                6+(8*position), 5+(8*position), 1+(8*position), // top

                0+(8*position), 3+(8*position), 7+(8*position), // bottom
                7+(8*position), 4+(8*position), 0+(8*position), // bottom
            };


            foreach(uint a in inds) currentIndices.Add(a);
            return currentIndices;
        }

        public static List<float> FloatArrayToList(float[] array) {
            List<float> l = new List<float>();

            foreach(float a in array) l.Add(a);
            return l;
        }

        public static List<uint> UintArrayToList(uint[] array) {
            List<uint> l = new List<uint>();

            foreach(uint a in array) l.Add(a);
            return l;
        }
    }
}