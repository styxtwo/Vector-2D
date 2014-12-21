using System;

namespace Vector2D {
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
            return Math.Acos(Dot(Normalise(v1), Normalise(v2)));
        }

        /// <summary>
        /// Normalises a vector.
        /// </summary>
        /// <param name="v">The vector to normalise.</param>
        /// <returns>The normalised vector.</returns>
        public static Vector Normalise(Vector v) {
            return v / v.Length();
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
        /// Interpolates linearly between two vectors. 
        /// </summary>
        /// <param name="v1">The first vector. </param>
        /// <param name="v2">The second vector. </param>
        /// <param name="fraction">The fraction to interpolate with. </param>
        /// <returns>The interpolated vector. </returns>
        public static Vector Lerp(Vector v1, Vector v2, double fraction) {
            return (1 - fraction) * v1 + fraction * v2;
        }
    }
}
