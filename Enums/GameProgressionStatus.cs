using CwLibNet.IO;

namespace CwLibNet.Enums
{
    public enum GameProgressionStatus
    {
        // NEW_GAME(0)
        NEW_GAME,
        // POD_ARRIVAL(1)
        POD_ARRIVAL,
        // ENTERED_STORY_LEVEL(2)
        ENTERED_STORY_LEVEL,
        // FIRST_LEVEL_COMPLETED(3)
        FIRST_LEVEL_COMPLETED,
        // GAME_PROGRESSION_COMPLETED(4)
        GAME_PROGRESSION_COMPLETED,
        // FIRST_GROUP_COMPLETED(4)
        FIRST_GROUP_COMPLETED 

        // --------------------
        // TODO enum body members
        // private final int value;
        // GameProgressionStatus(int value) {
        //     this.value = value;
        // }
        // public Integer getValue() {
        //     return this.value;
        // }
        // /**
        //  * Attempts to get GameProgressionStatus from value.
        //  *
        //  * @param value Game progression status value
        //  * @return GameProgressionStatus
        //  */
        // public static GameProgressionStatus fromValue(int value) {
        //     for (GameProgressionStatus status : GameProgressionStatus.values()) {
        //         if (status.value == value)
        //             return status;
        //     }
        //     return GameProgressionStatus.NEW_GAME;
        // }
        // --------------------
    }
}