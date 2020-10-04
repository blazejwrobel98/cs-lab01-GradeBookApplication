using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        string Name;
        GradeBookType Type = new GradeBookType();
        public StandardGradeBook(string name) : base(name)
        {
            Name = name;
            Type = GradeBookType.Standard;
        }
        
    }
}
