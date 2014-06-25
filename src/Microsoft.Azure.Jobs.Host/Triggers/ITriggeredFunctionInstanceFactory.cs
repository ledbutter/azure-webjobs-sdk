﻿using System;
using Microsoft.Azure.Jobs.Host.Executors;

namespace Microsoft.Azure.Jobs.Host.Triggers
{
    internal interface ITriggeredFunctionInstanceFactory<TTriggerValue>
    {
        IFunctionInstance Create(TTriggerValue value, Guid? parentId);
    }
}