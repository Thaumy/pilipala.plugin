﻿namespace pilipala.plugin

open System
open fsharper.op
open fsharper.alias
open pilipala.pipeline
open pilipala.pipeline.post
open pilipala.util.text

type Markdown(render: IPostRenderPipelineBuilder) =

    do
        let f (id: i64, v: string) = id, { markdown = v }.intoHtml().html
        render.Body.collection.Add <| After f
