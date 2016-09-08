// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using AspNetCoreViewModels.ViewModels.Shared;

namespace AspNetCoreViewModels.ViewModels.Default.Calendar
{
  public class CalendarViewModel
  {
    public DateTime Date { get; set; }
    public DayViewModel[,] Days { get; set; }
  }
}