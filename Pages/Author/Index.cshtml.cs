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
    public class IndexModel : PageModel
    {
        private readonly Muzsi_Henrietta_Lab2.Data.Muzsi_Henrietta_Lab2Context _context;

        public IndexModel(Muzsi_Henrietta_Lab2.Data.Muzsi_Henrietta_Lab2Context context)
        {
            _context = context;
        }

        public IList<Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Authors = await _context.Authors.ToListAsync();
            }
        }
    }
}
