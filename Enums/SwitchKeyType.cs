using CwLibNet.IO;

namespace CwLibNet.Enums
{
    public enum SwitchKeyType
    {
        // MAGNETIC(0)
        MAGNETIC,
        // IMPACT(1)
        IMPACT 

        // --------------------
        // TODO enum body members
        // private final int value;
        // SwitchKeyType(int value) {
        //     this.value = value;
        // }
        // public Integer getValue() {
        //     return this.value;
        // }
        // public static SwitchKeyType fromValue(int value) {
        //     for (SwitchKeyType type : SwitchKeyType.values()) {
        //         if (type.value == value)
        //             return type;
        //     }
        //     return null;
        // }
        // --------------------
    }
    public sealed class SwitchKeyBody
    {
        private readonly SwitchKeyType value;

        SwitchKeyBody(int value)
        {
            this.value = (SwitchKeyType)(value);
        }

        public SwitchKeyType getValue()
        {
            return this.value;
        }

        public static SwitchKeyBody fromValue(int value)
        {
            if (Enum.IsDefined(typeof(SwitchKeyType), value))
                return new SwitchKeyBody(value);
            return default(SwitchKeyBody);
        }
    }
}