using System;

namespace BasicVector {
    /// <summary>
    /// Provides basic utilites for Vectors.
    /// </summary>
    public class VectorUtil {
        /// <summary>
        /// Returns the dot product of the vectors.
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <returns>The dot product of the vectors. </returns>
        public static double Dot(Vector v1, Vector v2) {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        /// <summary>
        /// Returns the cross product of the vectors.
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <returns>The cross product of the vectors. </returns>
        public static double Cross(Vector v1, Vector v2) {
            return v1.X * v2.Y - v1.Y * v2.X;
        }

        /// <summary>
        /// Returns the angle between two vectors.
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <returns>The angle between two vectors. </returns>
        public static double Angle(Vector v1, Vector v2) {
            return Math.Acos(Dot(Normalize(v1), Normalize(v2)));
        }

        /// <summary>
        /// Normalises a vector.
        /// </summary>
        /// <param name="v">The vector to normalize.</param>
        /// <returns>The normalized vector.</returns>
        public static Vector Normalize(Vector v) {
            if (v == Vector.Zero) {
                return Vector.Zero;
            }
            return v / v.Length();
        }

        /// <summary>
        /// Sets the length of the vector.
        /// </summary>
        /// <param name="v">The vector whose length to set.</param>
        /// <param name="length">The length of the vector.</param>
        /// <returns>The vector with correct length.</returns>
        public static Vector SetLength(Vector v, double length) {
            return Normalize(v) * length;
        }

        /// <summary>
        /// Rotate a vector by a certain angle.
        /// </summary>
        /// <param name="v">The vector to rotate. </param>
        /// <param name="angle">The angle to rotate with. </param>
        /// <returns>The rotated vector. </returns>
        public static Vector Rotate(Vector v, double angle) {
            double X = v.X * Math.Cos(angle) - v.Y * Math.Sin(angle);
            double Y = v.X * Math.Sin(angle) + v.Y * Math.Cos(angle);
            return new Vector(X, Y);
        }

        /// <summary>
        /// Rotates the vector left by a 90 degrees turn.
        /// </summary>
        /// <param name="v">The vector to turn. </param>
        /// <returns>The rotated vector. </returns>
        public static Vector TurnLeft(Vector v) {
            return new Vector(-v.Y, v.X);
        }

        /// <summary>
        /// Rotates the vector right by a 90 degrees turn.
        /// </summary>
        /// <param name="v">The vector to turn. </param>
        /// <returns>The rotated vector. </returns>
        public static Vector TurnRight(Vector v) {
            return new Vector(v.Y, -v.X);
        }

        /// <summary>
        /// Determines the distance between the two vectors.
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <returns>The distance between the vectors.</returns>
        public static double Distance(Vector v1, Vector v2) {
            return (v1 - v2).Length();
        }

        /// <summary>
        /// Determines the squared distance between the two vectors.
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <returns>The squared distance between the vectors.</returns>
        public static double SquaredDistance(Vector v1, Vector v2) {
            return (v1 - v2).SquaredLength();
        }

        /// <summary>
        /// Interpolates linearly between two vectors. 
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <param name="fraction">The fraction to interpolate with. </param>
        /// <returns>The interpolated vector. </returns>
        public static Vector Lerp(Vector v1, Vector v2, double fraction) {
            return (1 - fraction) * v1 + fraction * v2;
        }

        /// <summary>
        /// Reflect a vector along a normal.
        /// </summary>
        /// <param name="v">The vector to reflect.</param>
        /// <param name="normal">The normal to reflect it along.</param>
        /// <returns>The reflected vector. </returns>
        public static Vector Reflect(Vector v, Vector normal) {
            Vector n = Normalize(normal);
            return 2 * (Dot(v, n)) * n - v;
        }

        /// <summary>
        /// Clamps the vector length between the two imput lengths (inclusive).
        /// </summary>
        /// <param name="v">The vector to clampl</param>
        /// <param name="min">The inclusive minimum length.</param>
        /// <param name="max">The inclusive maximum length.</param>
        /// <returns>The clamped vector.</returns>
        public static Vector ClampLength(Vector v, double min, double max) {
            double vLength = v.Length();
            if (vLength < min) {
                return SetLength(v, min);
            }
            if (vLength > max) {
                return SetLength(v, max);
            }
            return v;
        }

        /// <summary>
        /// Create a vector from a length and angle.
        /// </summary>
        /// <param name="length">The length of the new vector. </param>
        /// <param name="angle">The angle of the new vector. </param>
        /// <returns>The new vector</returns>
        public static Vector CreateVector(double length, double angle) {
            Vector vector = VectorUtil.Rotate(Vector.UnitX * length, angle);
            return vector;
        }

        /// <summary>
        /// Checks if the parameter vector is inside of the rectangle created by the other vectors.
        /// </summary>
        /// <param name="vector">The vector to check</param>
        /// <param name="topLeft">The top left of the rectangle.</param>
        /// <param name="bottomRight">The bottom right of the rectangle.</param>
        /// <returns>True if inside</returns>
        public static bool InsideRectangle(Vector vector, Vector topLeft, Vector bottomRight) {
            bool horizontal = (vector.X < bottomRight.X) && (vector.X > topLeft.X);
            bool vertical = (vector.Y > bottomRight.Y) && (vector.Y < topLeft.Y);
            return horizontal && vertical;
        }
    }
}
