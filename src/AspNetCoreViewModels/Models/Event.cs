// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace AspNetCoreViewModels.Models
{
  public class Event
  {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
  }
}