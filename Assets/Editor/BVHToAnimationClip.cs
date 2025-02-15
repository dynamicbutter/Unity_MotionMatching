﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class BVHToAnimationClip : AssetPostprocessor
{
  void OnPreprocessAsset()
  {
    // if (assetImporter.importSettingsMissing)
    // {
    //   if (!assetPath.Contains(".bvh")) { return; }

    //   // TODO: BVH to AnimationClip logic here
    //   FileInfo fi = new FileInfo(assetPath);
    //   string filename = fi.Name;
    //   string bvhData = File.ReadAllText(assetPath);
    //   BVHProcessor bp = new BVHProcessor(bvhData, filename);
    //   AnimationClip clip = new AnimationClip();
    //   string name = filename.Split('.')[0];

    //   foreach (BVHBone bone in bp.boneList)
    //   {
    //     for (int c = 0; c < bone.channels.Length; c++)
    //     {
    //       if (!bone.channels[c].enabled) continue;

    //       Keyframe[] keyframes = new Keyframe[bp.frames];
    //       float time = 0;
    //       for (int i = 0; i < bp.frames; i++)
    //       {
    //         keyframes[i] = new Keyframe(time, bone.channels[c].values[i]);
    //         time += bp.frameTime;
    //       }
    //       AnimationCurve curve = new AnimationCurve(keyframes);
    //       Debug.Log(bone.GetBonePath());
    //       clip.SetCurve(bone.GetBonePath(), typeof(Transform), GetChannelPropertyName(c), curve);
    //     }
    //   }
    //   AssetDatabase.CreateAsset(clip, "Assets/Resources/" + name + ".anim");
    // }

  }
  private string GetChannelPropertyName(int ch)
  {
    switch (ch)
    {
      case 0: return "localPosition.x";
      case 1: return "localPosition.y";
      case 2: return "localPosition.z";
      case 3: return "localRotation.x";
      case 4: return "localRotation.y";
      case 5: return "localRotation.z";
      default: return "";
    }
  }
}
