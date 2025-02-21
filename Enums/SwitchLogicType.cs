using CwLibNet.IO;

namespace CwLibNet.Enums
{
    public enum SwitchLogicType
    {
        // AND(0)
        AND,
        // OR(1)
        OR,
        // XOR(2)
        XOR,
        // NOT(3)
        NOT,
        // NOP(4)
        NOP 

        // --------------------
        // TODO enum body members
        // private final int value;
        // SwitchLogicType(int value) {
        //     this.value = value;
        // }
        // public Integer getValue() {
        //     return this.value;
        // }
        // public static SwitchLogicType fromValue(int value) {
        //     for (SwitchLogicType type : SwitchLogicType.values()) {
        //         if (type.value == value)
        //             return type;
        //     }
        //     return null;
        // }
        // --------------------
    }
    public sealed class SwitchLogicBody
    {
        private readonly SwitchLogicType value;

        SwitchLogicBody(int value)
        {
            this.value = (SwitchLogicType)(value);
        }

        public SwitchLogicType getValue()
        {
            return this.value;
        }

        public static SwitchLogicBody fromValue(int value)
        {
            if (Enum.IsDefined(typeof(SwitchLogicType), value))
                return new SwitchLogicBody(value);
            return default(SwitchLogicBody);
        }
    }
}