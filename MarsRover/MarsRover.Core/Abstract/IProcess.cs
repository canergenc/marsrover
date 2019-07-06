using MarsRover.Core.Enums;
using MarsRover.Core.Models;

namespace MarsRover.Core.Abstract
{
    public interface IProcess
    {
        /// <summary>
        /// Rover move start process function
        /// </summary>
        /// <param name="coords">XCoord, YCoord</param>
        /// <param name="orientations">Example "LMRM"</param>
        BaseOutputModel StartMoveOrientation(CoordinateModel coordInput,
                                             string orientations,
                                             PlateauModel plateauInput,
                                             DirectionEnum directionEnum = DirectionEnum.N);
    }
}
