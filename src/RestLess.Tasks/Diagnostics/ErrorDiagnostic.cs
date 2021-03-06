﻿using System;
using RestLess.Tasks.Exceptions;

namespace RestLess.Tasks.Diagnostics
{
    internal class ErrorDiagnostic : Diagnostic
    {
        public ErrorDiagnostic(string code) : base("error", code) { }

        public ErrorDiagnosticException ToException()
        {
            return new ErrorDiagnosticException(this);
        }

        public ErrorDiagnosticException ToException(Exception ex)
        {
            return new ErrorDiagnosticException(this, ex);
        }
    }
}
