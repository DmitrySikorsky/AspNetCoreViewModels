// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using AspNetCoreViewModels.DataAccess;

namespace AspNetCoreViewModels.ViewModels
{
  public abstract class ViewModelBuilderBase
  {
    protected IStorage Storage { get; private set; }

    public ViewModelBuilderBase(IStorage storage)
    {
      this.Storage = storage;
    }
  }
}