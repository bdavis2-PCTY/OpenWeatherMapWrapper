using OpenWeatherMapWrapper.Enums;

namespace OpenWeatherMapWrapper.Helpers
{
    internal static class DirectionHelper
    {
        private static int _directionItemCount;
        private static double _degreeCalculation;

        static DirectionHelper()
        {
            _directionItemCount = System.Enum.GetValues(typeof(CardinalDirectionEnum)).Length;

            // Ensure that the number of items is dividable by the 4 base cardinal directions
            if (_directionItemCount % 4 != 0)
            {
                throw new System.Exception($"Number of items in {nameof(CardinalDirectionEnum)} must be dividable by 4");
            }

            // Calculate the number of degrees for each direction
            _degreeCalculation = (360d / _directionItemCount);
        }

        /// <summary>
        /// Gets the cardinal direction from a degree
        /// https://stackoverflow.com/questions/7490660/converting-wind-direction-in-angles-to-text-words
        /// </summary>
        /// <param name="pDegree"></param>
        /// <returns></returns>
        public static CardinalDirectionEnum GetCardinalDirectionFromDegree(double pDegree)
        {
            int enumIndex = (int)(((pDegree / _degreeCalculation) + 0.5) % _directionItemCount);
            return (CardinalDirectionEnum)enumIndex;
        }
    }
}