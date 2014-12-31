using System;

namespace BasicVector {
    /// <summary>
    /// Provides basic utilites for angles.
    /// </summary>
    public class AngleUtil {

        /// <summary>
        /// Converts an angle in degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>The angle in radians.</returns>
        public static double ToRadian(double angle) {
            return Math.PI * angle / 180.0;
        }

        /// <summary>
        /// Converts an angle in radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>The angle in degrees.</returns>
        public static double ToDegrees(double angle) {
            return angle * (180.0 / Math.PI);
        }
    }
}
