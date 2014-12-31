﻿using System;

namespace BasicVector {
    /// <summary>
    /// Provides the vector class that is the basis for this project.
    /// </summary>
    public class Vector {
        /// <summary>
        /// Static constant for the zero vector.
        /// </summary>
        public readonly static Vector Zero = new Vector();

        /// <summary>
        /// Static constant for the unit vector.
        /// </summary>
        public readonly static Vector One = new Vector(1, 1);

        /// <summary>
        /// Static constant for the unit X vector.
        /// </summary>
        public readonly static Vector UnitX = new Vector(1, 0);

        /// <summary>
        /// Static constant for the unit Y vector.
        /// </summary>
        public readonly static Vector UnitY = new Vector(0, 1);

        /// <summary>
        /// X coordinate.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Empty constructor, sets X and Y to zero.
        /// </summary>
        public Vector() {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Main Constructor.
        /// </summary>
        /// <param name="xValue">The x value of the vector. </param>
        /// <param name="yValue">The y value of the vector. </param>
        public Vector(double xValue, double yValue) {
            X = xValue;
            Y = yValue;
        }

        /// <summary>
        /// Returns the length of the vector.
        /// </summary>
        /// <returns>The length of the vector.</returns>
        public double Length() {
            return Math.Sqrt(X * X + Y * Y);
        }

        /// <summary>
        /// Returns the squared length of the vector. Useful for optimalisation.
        /// </summary>
        /// <returns>The squared length of the vector.</returns>
        public double SquaredLength() {
            return X * X + Y * Y;
        }

        /// <summary>
        /// Returns the absolute angle of the vector.
        /// </summary>
        /// <returns></returns>
        public double Angle() {
            return Math.Atan2(Y, X);
        }

        /// <summary>
        /// Overrides the Equals method to provice better equality for vectors.
        /// </summary>
        /// <param name="obj">The object to test equality against.</param>
        /// <returns>Whether the objects are equal. </returns>
        public override bool Equals(object obj) {
            if (Object.ReferenceEquals(obj, null)) {
                return false;
            }

            if (Object.ReferenceEquals(this, obj)) {
                return true;
            }

            if (this.GetType() != obj.GetType())
                return false;

            Vector other = (obj as Vector);
            return (X == other.X) && (Y == other.Y);
        }

        /// <summary>
        /// Overrides the hashcode.
        /// </summary>
        /// <returns>The hashcode for the vector.</returns>
        public override int GetHashCode() {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// ToString method overriden for easy printing/debugging.
        /// </summary>
        /// <returns>The string representation of the vector.</returns>
        public override string ToString() {
            return "(" + X + ", " + Y + ")";
        }

        /*----------------------- Operator overloading below ------------------------------*/
        public static bool operator ==(Vector v1, Vector v2) {
            if (object.ReferenceEquals(v1, null)) {
                return object.ReferenceEquals(v2, null);
            }
            return v1.Equals(v2);
        }
        public static bool operator !=(Vector v1, Vector v2) {
            return !(v1 == v2);
        }
        public static Vector operator +(Vector a, Vector b) {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
        public static Vector operator -(Vector a, Vector b) {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }
        public static Vector operator *(Vector a, Vector b) {
            return new Vector(a.X * b.X, a.Y * b.Y);
        }
        public static Vector operator *(Vector a, double b) {
            return new Vector(a.X * b, a.Y * b);
        }
        public static Vector operator *(double a, Vector b) {
            return new Vector(b.X * a, b.Y * a);
        }
        public static Vector operator /(Vector a, Vector b) {
            return new Vector(a.X / b.X, a.Y / b.Y);
        }
        public static Vector operator /(Vector a, double b) {
            return new Vector(a.X / b, a.Y / b);
        }
        public static Vector operator -(Vector a) {
            return new Vector(-a.X, -a.Y);
        }
    }
}