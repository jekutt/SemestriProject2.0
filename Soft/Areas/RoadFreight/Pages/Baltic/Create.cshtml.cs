﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SemestriProject.Domain.RoadFreight;
using SemestriProject.Pages.RoadFreight;

namespace SemestriProject.Soft.Areas.RoadFreight.Pages.Baltic
{
    public class CreateModel : BalticsPage
    {
        public CreateModel(IBalticsRepository r) : base(r)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
