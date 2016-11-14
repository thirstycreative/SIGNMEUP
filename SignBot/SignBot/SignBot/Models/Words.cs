using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace SignBot.Models
{
    public static class Words
    {
        private static StringDictionary wordVideos = new StringDictionary()
        {
            {"a", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410391/csw8ggjwyeggagpxmiak.mp4"},
            {"b", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410704/nud6xxvxzbbuyfpismqj.mp4"},
            {"c", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475499142/p3ca5fl5wjph2xxolrhp.mp4"},
            {"d", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554342/me1tizbkrsotspqxiudu.mp4"},
            {"e", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410481/kdxzn4zzwfypu1tpzwpx.mp4"},
            {"f", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554428/aulj1vjhdeewtuqimvfd.mp4"},
            {"g", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554475/hua1rmxmgmvnfhmcgqew.mp4"},
            {"h", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554587/touey4fgevp05tt7j3un.mp4"},
            {"i", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554678/wyr8yjfqrlbxgiq9dvl0.mp4"},
            {"j", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554730/cpknht2isnzjo1m7ruqv.mp4"},
            {"k", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554829/a2p0ycekjaby88i1btug.mp4"},
            {"l", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554901/viwqycf832udaw0xdd6d.mp4"},
            {"m", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554952/lakc9w1m9cq3nkqd0sh4.mp4"},
            {"n", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475554991/iandeaiemn6vsrgddfoe.mp4"},
            {"o", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475555117/aesk1ddi0b9fxjvok2ks.mp4"},
            {"p", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475556436/lgezqylpylmqhl58ucfe.mp4"},
            {"q", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475556542/h7bpo7har7knsambvf2f.mp4"},
            {"r", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410444/tb56udli4eol9w6rngeq.mp4"},
            {"s", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475556630/er6xqpyiqhpkmcmucswr.mp4"},
            {"t", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475556717/zs5v1sgqe8oja119ef32.mp4"},
            {"u", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475558158/q19kbh9j9iapx90p8ywr.mp4"},
            {"v", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475558652/pu5zqw5mm2r78zcdlzii.mp4"},
            {"w", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475558705/pjtql3zlgwdl7vojnxko.mp4"},
            {"x", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475558753/r1fgmnza2wisitzgjqij.mp4"},
            {"y", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475558834/yaz9d7dlfuzf6r2rxduj.mp4"},
            {"z", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559021/rspc9tnpkxalnnajmbti.mp4"},
            //letters above this line
            //words below this line
            {"your", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561334/hyxxvwuufsys06ptzsgi.mp4" },
            {"you", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410532/evykhb1kk2osuzk7oxct.mp4" },
            {"why", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561299/rlbr84sgt84ludltv5me.mp4" },
            {"who", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561285/p4iuafrgnr4r5wpk7oon.mp4" },
            {"which", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561274/xtnxlyizgpeiiolkmuvj.mp4" },
            {"where", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561233/ji5cryqpwjxabvaebfdt.mp4" },
            {"when", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561210/srwlryiilwsvjrzznfu7.mp4" },
            {"what", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561192/jgxmleblbbhhxckgjlkv.mp4" },
            {"want", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561167/wbrdlr4dvc6sotb7l5yk.mp4" },
            {"Tripti", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475405903/tbbkytdvh3aftxzsfitx.mp4" },
            {"time", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561066/xnhjmbuwrlp9jxazxvcr.mp4" },
            {"sick", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561044/p1xzprtiqkqqonerkcug.mp4" },
            {"Sarah", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475410603/yse5x1qpldluz4cw3ss1.mp4" },
            {"Roslyn", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475561023/brqiemaivuc94lmuypaf.mp4" },
            {"restaurant", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560970/sik0greqfwrdwhu3tpsi.mp4" },
            {"police", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560942/aghre1ynycxhkuvoedbm.mp4" },
            {"on", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560833/hpttfjvy8az6fucaxc2b.mp4" },
            {"need", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560807/gscsau63mjtqnhkjiyk3.mp4" },
            {"naughty", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560786/h0cfl9lsvoeslgqowoyw.mp4" },
            {"name", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560767/srkw4ccn5mztv0xr4bwr.mp4" },
            {"my", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560747/q8uzqkektokaski9dxko.mp4" },
            {"little", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560711/lhy8bbengcrul0ab4xxx.mp4" },
            {"how", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560688/s3xe20uy3x4olztmafbf.mp4" },
            {"hospital", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560661/unlswmtmajtdcfaqyijh.mp4" },
            {"help", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560617/wlhwklbtwv5buzjtst1x.mp4" },
            {"hello", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560583/kw2hjucn0ndssmvgx3pl.mp4" },
            {"go", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475560545/xmbcslu8vd1q2nsbs9vy.mp4" },
            {"from", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475654261/fymg7edfmzpc9uywxm8o.mp4" },
            {"Elise", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559629/un5lbcdark5rqanxyabi.mp4" },
            {"dog", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559512/iqbmeda2struw8rcbt0n.mp4" },
            {"doctor", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559477/dfx8veaeevyw0zzrwfnw.mp4" },
            {"do", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559415/sf3idgczshpqoaouf1to.mp4" },
            {"come", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559368/zl0cl8ka2telqxxrlmgz.mp4" },
            {"cat", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559336/ojzs0zgxsyq1yicu6200.mp4" },
            {"carpet", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559307/dboo6bhukjhuibrjutms.mp4" },
            {"call", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559269/kwakrptzoggxeeawqpas.mp4" },
            {"big", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559229/zbiaqv7zjq6pvpx4ipjc.mp4" },
            {"ambulance", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559162/zm6tieaios2htcjkfdh4.mp4" },
            {"Alex", "http://res.cloudinary.com/dwa0fvkfp/video/upload/v1475559100/xryikecozoujyigyjjuy.mp4" }
        };

        public static string UrlForWord(string word)
        {
            string url = string.Empty;

            if (wordVideos.ContainsKey(word))
            {
                url = wordVideos[word];
            }
            return url;
        }
    }
}