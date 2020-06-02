﻿using System;
using Proyectofuncion;

namespace Proyectofunciontest
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();

        private NullScope() { }

        public void Dispose() { }
    }
}