﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Core.DTOs
{
    public class ComplaintTypeDTO
    {

        [Required(ErrorMessage = "Type name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Type name must be between 1 and 100 characters.")]
        public string TypeName { get; set; }

        [Required(ErrorMessage = "DepartmentID is required.")]

        public int DepartmentID { get; set; }
    }
    public class ComplaintTypeUpdateDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Type name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Type name must be between 1 and 100 characters.")]
        public string TypeName { get; set; }

       
    }
    public class GetComplaintTypeDTO
        {

            public int Id { get; set; }

            public string TypeName { get; set; }

            public int DepartmentID { get; set; }
            public string DepartmentName { get; set; }
        }
    }

