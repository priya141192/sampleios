using System;
namespace SampleTask.IOS.Dto
{
    public class DoctorDto
    {
        public DoctorDto()
        {
        }

        public string ProfileImage { get; set; }
        public string DocName { get; set; }
        public string Department { get; set; }
        public string Category { get; set; }
        public string Reviews { get; set; }
        public CellType CellType { get; set; }
    }
}
