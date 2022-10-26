using SoftwareEngineeringChallenge.Entities;

namespace SoftwareEngineeringChallenge.Interfaces
{
    /// <summary>
    /// Interface that contains all methos to use in the program.
    /// </summary>
    public interface IUtilities
    {
        IEnumerable<Marble> SortByColor(IEnumerable<Marble> marbles);

        IEnumerable<Marble> GetByWeight(IEnumerable<Marble> marbles, float weight);

        IEnumerable<Marble> GetPalindrome(IEnumerable<Marble> marbles);
    }
}
