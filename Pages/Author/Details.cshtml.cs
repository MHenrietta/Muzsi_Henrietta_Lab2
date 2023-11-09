﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muzsi_Henrietta_Lab2.Data;
using Muzsi_Henrietta_Lab2.Models;

namespace Muzsi_Henrietta_Lab2.Pages.Author
{
    public class DetailsModel : PageModel
    {
        private readonly Muzsi_Henrietta_Lab2.Data.Muzsi_Henrietta_Lab2Context _context;

        public DetailsModel(Muzsi_Henrietta_Lab2.Data.Muzsi_Henrietta_Lab2Context context)
        {
            _context = context;
        }

      public Authors Authors { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Authors == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else 
            {
                Authors = authors;
            }
            return Page();
        }
    }
}