

using AI.Core.Model.BPM;
using System.Threading.Tasks;
using System.Collections.Generic;
using ZhonTai.Admin.Core.Dto;
using AI.BPM.Services.WorkItem.Output;

using AI.BPM.Domain.WorkflowTemplate;
using AI.BPM.Domain.Activity;
namespace AI.BPM.Services.Activity
{
    /// <summary>
    /// ��ڵ����
    /// </summary>
    public interface IActivityService
    {
        ActivityModel GetStartActivity(WorkflowTemplateEntity tpl);

        /// <summary>
        /// ����ǰһ����ӹ��c ,�˰汾����ͼ����ͬʱ������򣬹ʴ˺�������
        /// </summary>
        /// <param name="tpl"></param>
        /// <param name="currentActivity"></param>
        /// <returns></returns>
       // ActivityModel FindPreviousActivity(WorkflowTemplateEntity tpl, ActivityModel currentActivity);

        Dictionary<string, object> UpdateForm(string currentForm, List<FieldPermission> permissions, Dictionary<string, object> inputFields);
        /// <summary>
        /// �@ȡ�����O�����formdata
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="formData"></param>
        /// <returns></returns>
        string GetPermissionFormData(List<FieldPermission> ps, string formData);
        /// <summary>
        /// ��ȡ�
        /// </summary>
        /// <param name="tpl"></param>
        /// <param name="activityId"></param>
        /// <returns></returns>
        ActivityModel GetActivity(WorkflowTemplateEntity tpl, string activityId);
        /// <summary>
        /// ���Һ���Activity
        /// </summary>
        /// <param name="tpl"></param>
        /// <param name="currentActivityId"></param>
        /// <param name="nextActivities"></param>
        void FindNextActivity(WorkflowTemplateEntity tpl, string currentActivityId, List<ActivityModel> nextActivities, Dictionary<string, object> dicForm );
   

        
    }
}