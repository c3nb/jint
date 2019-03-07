﻿using BenchmarkDotNet.Attributes;

namespace Jint.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayStressBenchmark : SingleScriptBenchmark
    {
        protected override string Script => "var ret=[],tmp,num=100,i=256;for(var j1=0;j1<i*15;j1++){ret=[];ret.length=i}for(var j2=0;j2<i*10;j2++){ret=new Array(i)}ret=[];for(var j3=0;j3<i;j3++){ret.unshift(j3)}ret=[];for(var j4=0;j4<i;j4++){ret.splice(0,0,j4)}var a=ret.slice();for(var j5=0;j5<i;j5++){tmp=a.shift()}var b=ret.slice();for(var j6=0;j6<i;j6++){tmp=b.splice(0,1)}ret=[];for(var j7=0;j7<i*25;j7++){ret.push(j7)}var c=ret.slice();for(var j8=0;j8<i*25;j8++){tmp=c.pop()}var done = true;";

        [Params(20)]
        public override int N { get; set; }
    }
}