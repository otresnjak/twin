﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class RandomUtils
{
    public static T Pick<T>(T[] options)
    {
        int idx = Random.Range(0, options.Length);
        return options[idx];
    }
}