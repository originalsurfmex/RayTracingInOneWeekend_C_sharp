using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracingOneWeekend
{
    /// <summary>
    /// Creates Vectors with X,Y,Z and helper functions
    /// </summary>
    using Point3 = Vec3;
    using Color = Vec3;
    public class Vec3
    {
        // parameters
        /// <summary>
        /// 3-Item Vector Array
        /// </summary>
        public double[] E = new double[3];
        /// <summary>
        /// get X from E[0]
        /// </summary>
        public double X { get => this.E[0]; }
        /// <summary>
        /// get Y from E[1]
        /// </summary>
        public double Y { get => this.E[1]; }
        /// <summary>
        /// get Z from E[2]
        /// </summary>
        public double Z { get => this.E[2]; }

        /// <summary>
        /// An indexer to Get and Set the X,Y,Z of a vector by accessing it's array index
        /// </summary>
        /// <param name="i">[0], [1] or [2]</param>
        /// <returns>Gets the index value or sets a new value</returns>
        public double this[int i]
        {
            get
            {
                if (i == 0) { return this.E[i]; }
                else if (i == 1) { return this.E[i]; }
                else if (i == 2) { return this.E[i]; }
                else { throw new Exception(); } //in case of something not covered
            }
            set
            {
                if (i == 0) { this.E[i] = value; }
                else if (i == 1) { this.E[i] = value; }
                else if (i == 2) { this.E[i] = value; }
                else { throw new Exception(); }
            }
        }

        //constructors
        /// <summary>
        /// Vector Array initialized as 0,0,0
        /// </summary>
        public Vec3() => Array.Fill(this.E, 0);

        /// <summary>
        /// Initialize Vector with user-defined X,Y,Z
        /// </summary>
        /// <param name="e0">X value</param>
        /// <param name="e1">Y value</param>
        /// <param name="e2">Z value</param>
        public Vec3(double e0, double e1, double e2)
        {
            this.E[0] = e0;
            this.E[1] = e1;
            this.E[2] = e2;
        }

        // methods
        /// <summary>
        /// Returns X^2 + B^2 + C^2, used in the Length function
        /// </summary>
        private double LengthSquared => E[0] * E[0] + E[1] * E[1] + E[2] * E[2];
        /// <summary>
        /// Return the Length of a Vector
        /// </summary>
        public double Length => Math.Sqrt(LengthSquared);

        // operator overload methods
        public static Vec3 operator -(Vec3 v) => new Vec3(-v.E[0], -v.E[1], -v.E[2]);
        /// <summary>
        /// Add two vectors 
        /// </summary>
        /// <param name="va">First Vector to be added</param>
        /// <param name="vb">Second Vector to be added</param>
        /// <returns>NEW vector, assigned to the first argument</returns>
        public static Vec3 operator +(Vec3 va, Vec3 vb)
        {
            double newX = va[0] + vb[0];
            double newY = va[1] + vb[1];
            double newZ = va[2] + vb[2];
            Vec3 vc = new Vec3(newX, newY, newZ);
            return vc;
        }
        /// <summary>
        /// Addition Overload - Mutates the first vector and returns it.
        /// </summary>
        /// <param name="va">First Vector to be added</param>
        /// <param name="vb">Second Vector to be added</param>
        /// <returns></returns>
        //public static Vec3 operator +(Vec3 va, Vec3 vb)
        //{
        //    va[0] = va[0] + vb[0];
        //    va[1] = va[1] + vb[1];
        //    va[2] = vb[2] + vb[2];
        //    return va;
        //}

        /// <summary>
        /// Divide a vector by a double
        /// </summary>
        /// <param name="v">Vector to be divided</param>
        /// <param name="b">Division factor</param>
        /// <returns>NEW vector assigned to the first argument</returns>
        public static Vec3 operator /(Vec3 v, double b)
        {
            double newX = v[0] / b;
            double newY = v[1] / b;
            double newZ = v[2] / b;
            Vec3 v2 = new Vec3(newX, newY, newZ);
            return v2;
        }
        /// <summary>
        /// Multiply a vector by a double
        /// </summary>
        /// <param name="v">Vector to be multiplied</param>
        /// <param name="b">Multiplication factor</param>
        /// <returns>NEW vector assigned to the first argument</returns>
        public static Vec3 operator *(Vec3 v, double b)
        {
            double newX = v[0] * b;
            double newY = v[1] * b;
            double newZ = v[2] * b;
            Vec3 v2 = new Vec3(newX, newY, newZ);
            return v2;
        }

        /// <summary>
        /// Override ToString, show the values of X, Y, Z
        /// </summary>
        /// <returns>X, Y, Z</returns>
        public override string ToString() => $"{this.X}, {this.Y}, {this.Z}";
    }
}
