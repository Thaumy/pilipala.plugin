﻿namespace pilipala.plugin

open System
open System.Collections
open System.Collections.Generic
open fsharper.op
open fsharper.typ
open fsharper.alias
open pilipala.plugin
open pilipala.pipeline
open pilipala.util.text
open pilipala.pipeline.post

type Config =
    { archived: HashSet<i64>
      scheduled: HashSet<i64> }

type PostStatus(postRenderBuilder: IPostRenderPipelineBuilder, cfg: IPluginCfgProvider) =

    let config =
        { json = cfg.config }.deserializeTo<Config> ()

    do
        let f id : _ * obj = id, config.archived.Contains(id)

        postRenderBuilder.["IsArchived"].collection.Add
        <| Replace(always f)

    do
        let f id : _ * obj = id, config.scheduled.Contains(id)

        postRenderBuilder.["IsScheduled"].collection.Add
        <| Replace(always f)
