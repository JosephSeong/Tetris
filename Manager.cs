using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tetris
{
    public struct accInfo
    {
        public string ID;
        public string PW;
        public string name;
        public int birthday;
        public int phoneNum;
        public string e_mail;
        public string address;
    }

    public class AccManager
    {
        public static List<accInfo?> accList = new List<accInfo?>();

        /// <summary>
        /// 매개변수 ID의 accInfo를 반환
        /// </summary>
        /// <param name="targetID"></param>
        /// <returns></returns>
        public accInfo? GetAccInfo(string targetID)
        {
            accInfo? targetAcc = new accInfo();

            if (accList.Any((acc) =>
            {
                if (acc.Value.ID == targetID)
                {
                    targetAcc = acc;
                    return true;
                }
                else
                    return false;
            })
            )
                return targetAcc;

            else return null;
        }
    }
}