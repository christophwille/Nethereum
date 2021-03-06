using System;

namespace Nethereum.ABI.FunctionEncoding
{
    public class ParameterOutput
    {
        public Parameter Parameter { get; set; }
        public int DataIndexStart { get; set; }
        public object Result { get; set; }
        public Type DecodedType { get; set; }
    }
}