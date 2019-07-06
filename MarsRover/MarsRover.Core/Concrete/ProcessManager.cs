using MarsRover.Core.Abstract;
using MarsRover.Core.Enums;
using MarsRover.Core.Models;
using System;

namespace MarsRover.Core.Concrete
{
    public class ProcessManager : IProcess
    {
        #region Properties
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public DirectionEnum RoverDirection { get; set; }

        #endregion

        #region Constructor
        public ProcessManager()
        {
            RoverDirection = DirectionEnum.N;
        }
        #endregion

        #region Move Process
        /// <summary>
        /// Rover move start process function
        /// </summary>
        /// <param name="coords"></param>
        /// <param name="directMoves"></param>
        public BaseOutputModel StartMoveOrientation(CoordinateModel coordInput, string orientations, PlateauModel plateauInput, DirectionEnum directionEnum = DirectionEnum.N)
        {
            var output = new BaseOutputModel { Success = true };
            XCoord = coordInput.XCoord;
            YCoord = coordInput.YCoord;
            RoverDirection = directionEnum;

            #region Control

            if (!PlateauCoordControl(plateauInput))
            {
                output.Error = "!Coordinate Error: You coordinates ( " + XCoord + " , " + YCoord + " )" + ". Coordinates exceed plateu areas. You Plateaus: W => " + plateauInput.Width + " H=>"+ plateauInput.Height + ". Please try again.";
                output.Success = false;
                return output;
            }

            #endregion

            #region Move Function

            foreach (var orientation in orientations)
            {
                if (orientation == (char)MoveOrientationEnum.Left)
                    LeftOrientation();
                else if (orientation == (char)MoveOrientationEnum.Right)
                    RightOrientation();
                else if (orientation == (char)MoveOrientationEnum.Move)
                    MoveOrientation();
                else
                {
                    output.Error = "Error : Unknown orientation you orientation " + orientation + " Orientation chracters (L,R,M). Please try again.";
                    output.Success = false;
                    return output;
                }
            }
            #endregion

            output.Result = "XCoord : " + XCoord + " YCoord : " + YCoord + " Direction : " + RoverDirection.ToString();
            return output;

        }

        /// <summary>
        /// Plateau and Coord control function
        /// </summary>
        /// <param name="plateauInput"></param>
        /// <returns>true: OK ,false : Coordinate Error </returns>
        private bool PlateauCoordControl(PlateauModel plateauInput)
        {
            if (XCoord < 0 || XCoord > plateauInput.Width || YCoord < 0 || YCoord > plateauInput.Height)
                return false;
            return true;
        }

        /// <summary>
        /// left 90 degree orientation function
        /// </summary>
        private void LeftOrientation()
        {
            switch (RoverDirection)
            {
                case DirectionEnum.N:
                    RoverDirection = DirectionEnum.W; //North 90 degress left => West
                    break;
                case DirectionEnum.W:
                    RoverDirection = DirectionEnum.S; //West 90 degress left => South
                    break;
                case DirectionEnum.S:
                    RoverDirection = DirectionEnum.E; //South 90 degress left => East
                    break;
                case DirectionEnum.E:
                    RoverDirection = DirectionEnum.N; //East 90 degress left => North
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Right 90 degree orientation function
        /// </summary>
        private void RightOrientation()
        {
            switch (RoverDirection)
            {
                case DirectionEnum.N:
                    RoverDirection = DirectionEnum.E; //North 90 degress right => East
                    break;
                case DirectionEnum.E:
                    RoverDirection = DirectionEnum.S;//East 90 degress right => South
                    break;
                case DirectionEnum.S:
                    RoverDirection = DirectionEnum.W;//South 90 degress right => West
                    break;
                case DirectionEnum.W:
                    RoverDirection = DirectionEnum.N;//West 90 degress right => North
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Rover move orientation
        /// </summary>
        private void MoveOrientation()
        {
            switch (RoverDirection)
            {
                case DirectionEnum.N:
                    YCoord += 1;
                    break;
                case DirectionEnum.E:
                    XCoord += 1;
                    break;
                case DirectionEnum.S:
                    YCoord -= 1;
                    break;
                case DirectionEnum.W:
                    XCoord -= 1;
                    break;
            }
        }

        #endregion

    }
}
