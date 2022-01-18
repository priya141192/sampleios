using System;
namespace SampleTask.IOS.Dto
{
    public class DashboardEntityDto
    {
        public DashboardEntityDto()
        {
        }

        public string HeaderText { get; set; }
        public string Option { get; set; }
        public bool IsOptionVisible { get; set; }
        public int ContentType { get; set; }
    }
}
