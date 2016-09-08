// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace AspNetCoreViewModels.DataAccess
{
  public class Storage : IStorage
  {
    public IEventRepository EventRepository { get; private set; }

    public Storage()
    {
      this.EventRepository = new EventRepository();
    }
  }
}