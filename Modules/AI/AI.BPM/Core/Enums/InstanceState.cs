using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.BPM.Core.Enums
{
    /// <summary>
    /// 流程状态
    /// </summary>
    public enum InstanceState
    {
        /// <summary>
        /// 未初始化
        /// </summary>
        [Description("未初始化")]
        UnInitiated = 1 | DisplayType.Info,
        /// <summary>
        /// 运行中
        /// </summary>
        [Description("运行中")]
        Running = 2 | DisplayType.Primary,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        Finished = 3 | DisplayType.Success,
        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")]
        Canceled = 4 | DisplayType.Warning,
        /// <summary>
        /// 流程异常
        /// </summary>
        [Description("异常")]
        Exceptional = 5 | DisplayType.Danger,
        /// <summary>
        /// 流程挂起
        /// </summary>
        [Description("挂起")]
        Suspended = 6 | DisplayType.Danger,
        /// <summary>
        /// 未知
        /// </summary>
        [Description("超时")]
        Timeout = 7 | DisplayType.Danger
    }
}
