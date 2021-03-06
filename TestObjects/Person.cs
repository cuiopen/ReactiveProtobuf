﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace TestObjects
{
    [ProtoContract(ImplicitFields = ImplicitFields.AllFields)]
    [ProtoInclude(100, typeof(Manager))]
    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
