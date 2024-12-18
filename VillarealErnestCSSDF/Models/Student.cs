namespace VillarealErnestCSSDF.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Gender { get; set; }
        public required int Year { get; set; }
        public required string Course { get; set; }
        public double GPA { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        
    }
}
