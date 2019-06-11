using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using KnowledgeShare.NewFolder;

namespace KnowledgeShare.Controllers
{
    public class PodMapper
    {
        public static ApiPod Pod2PodApi(Pod pod)
        {
            return new ApiPod
            {
                Id = pod.Id,
                Name = pod.Name
            };
        }

        public static ICollection<ApiPod> PodsList2ApiPods(ICollection<Pod> pods)
        {
            var ApiPodList = pods.Select(c => Pod2PodApi(c)).ToList();
            return ApiPodList;
        }

        public static Pod PodApi2Pod(ApiPod pod)
        {
            return new Pod
            {
                Id = pod.Id,
                Name = pod.Name
            };
        }

        public static ICollection<Pod> ApiPodsList2Pods(ICollection<ApiPod> pods)
        {
            var PodList = pods.Select(c => PodApi2Pod(c)).ToList();
            return PodList;
        }
    }
}
