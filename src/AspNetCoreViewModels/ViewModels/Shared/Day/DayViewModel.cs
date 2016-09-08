// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace AspNetCoreViewModels.ViewModels.Shared
{
  public class DayViewModel
  {
    public DateTime Date { get; set; }
    public bool IsNotCurrentMonth { get; set; }
    public bool IsWeekendOrHoliday { get; set; }
    public bool IsToday { get; set; }
    public IEnumerable<EventViewModel> Events { get; set; }
  }
}