using System;
using System.Collections.Generic;

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
        public CellType ContentType { get; set; }
        public List<CustomerDto> CustomerList { get; set; }
        public List<DoctorDto> DoctorList { get; set; }
    }

    public enum CellType
    {
        Customer,
        Doctor
    }
}
