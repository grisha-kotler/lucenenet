/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Lucene.Net.Store;
using Lucene.Net.Util;
using NUnit.Framework;

using Document = Lucene.Net.Documents.Document;
using FieldSelector = Lucene.Net.Documents.FieldSelector;
using CorruptIndexException = Lucene.Net.Index.CorruptIndexException;
using IndexReader = Lucene.Net.Index.IndexReader;
using Term = Lucene.Net.Index.Term;
using TermPositions = Lucene.Net.Index.TermPositions;

namespace Lucene.Net.Search
{
	
	/// <summary> Holds all implementations of classes in the o.a.l.search package as a
	/// back-compatibility test. It does not run any tests per-se, however if 
	/// someone adds a method to an interface or abstract method to an abstract
	/// class, one of the implementations here will fail to compile and so we know
	/// back-compat policy was violated.
	/// </summary>
	sealed class JustCompileSearch
	{
		
		private const System.String UNSUPPORTED_MSG = "unsupported: used for back-compat testing only !";
		
		internal sealed class JustCompileSearcher:Searcher
		{
			
			public /*protected internal*/ override Weight CreateWeight(Query query, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

            protected override void Dispose(bool disposing)
            {
                throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
            }
			
			public override Document Doc(int i, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int[] DocFreqs(Term[] terms, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override Explanation Explain(Query query, int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override Similarity Similarity
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		        set { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }

		    public override void  Search(Query query, Collector results, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  Search(Query query, Filter filter, Collector results, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override TopDocs Search(Query query, Filter filter, int n, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override TopFieldDocs Search(Query query, Filter filter, int n, Sort sort, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override TopDocs Search(Query query, int n, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override int DocFreq(Term term, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override Explanation Explain(Weight weight, int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int MaxDoc
			{
                get
                {
                    throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
                }
			}
			
			public override Query Rewrite(Query query, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  Search(Weight weight, Filter filter, Collector results, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override TopDocs Search(Weight weight, Filter filter, int n, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override TopFieldDocs Search(Weight weight, Filter filter, int n, Sort sort, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override Document Doc(int n, FieldSelector fieldSelector, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileCollector:Collector
		{
			
			public override void  Collect(int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetNextReader(IndexReader reader, int docBase, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetScorer(Scorer scorer)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override bool AcceptsDocsOutOfOrder
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }
		}
		
		internal sealed class JustCompileDocIdSet:DocIdSet
		{
			
			public override DocIdSetIterator Iterator(IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileDocIdSetIterator:DocIdSetIterator
		{
			public override int DocID()
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int NextDoc(IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int Advance(int target, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		[Serializable]
		internal sealed class JustCompileExtendedFieldCacheLongParser : Lucene.Net.Search.LongParser
		{
			
			public long ParseLong(System.String string_Renamed)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		[Serializable]
		internal sealed class JustCompileExtendedFieldCacheDoubleParser : Lucene.Net.Search.DoubleParser
		{
			
			public double ParseDouble(System.String string_Renamed)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileFieldComparator:FieldComparator
		{
			
			public override int Compare(int slot1, int slot2)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int CompareBottom(int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  Copy(int slot, int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetBottom(int slot)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetNextReader(IndexReader reader, int docBase, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override IComparable this[int slot]
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }
		}
		
		[Serializable]
		internal sealed class JustCompileFieldComparatorSource:FieldComparatorSource
		{
			
			public override FieldComparator NewComparator(System.String fieldname, int numHits, int sortPos, bool reversed)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		[Serializable]
		internal sealed class JustCompileFilter:Filter
		{
			// Filter is just an abstract class with no abstract methods. However it is
			// still added here in case someone will add abstract methods in the future.
            public override DocIdSet GetDocIdSet(IndexReader reader, IState state)
            {
                return null;
            }
		}
		
		internal sealed class JustCompileFilteredDocIdSet:FilteredDocIdSet
		{
			
			public JustCompileFilteredDocIdSet(DocIdSet innerSet):base(innerSet)
			{
			}
			
			public /*protected internal*/ override bool Match(int docid)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileFilteredDocIdSetIterator:FilteredDocIdSetIterator
		{
			
			public JustCompileFilteredDocIdSetIterator(DocIdSetIterator innerIter):base(innerIter)
			{
			}
			
			public /*protected internal*/ override bool Match(int doc)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileFilteredTermEnum:FilteredTermEnum
		{
			
			public override float Difference()
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override bool EndEnum()
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    /*protected internal*/ protected internal override bool TermCompare(Term term)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		/*internal sealed class JustCompilePhraseScorer : Lucene.Net.Search.PhraseScorer    // {{Not needed for Lucene.Net}}
		{

            internal JustCompilePhraseScorer(Weight weight, TermPositions[] tps, int[] offsets, Similarity similarity, byte[] norms)
                : base(weight, tps, offsets, similarity, norms)
            {
            }

		    protected internal override float PhraseFreq()
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}*/
		
		[Serializable]
		internal sealed class JustCompileQuery:Query
		{
			
			public override System.String ToString(System.String field)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		internal sealed class JustCompileScorer:Scorer
		{
			
			internal JustCompileScorer(Similarity similarity):base(similarity)
			{
			}
			
			public /*protected internal*/ override bool Score(Collector collector, int max, int firstDocID, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float Score(IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int DocID()
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int NextDoc(IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override int Advance(int target, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		[Serializable]
		internal sealed class JustCompileSimilarity:Similarity
		{
			
			public override float Coord(int overlap, int maxOverlap)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float Idf(int docFreq, int numDocs)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float LengthNorm(System.String fieldName, int numTokens)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float QueryNorm(float sumOfSquaredWeights)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float SloppyFreq(int distance)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override float Tf(float freq)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
		
		[Serializable]
		internal sealed class JustCompileSpanFilter:SpanFilter
		{
			public override SpanFilterResult BitSpans(IndexReader reader, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
            public override DocIdSet GetDocIdSet(IndexReader reader, IState state)
            {
                return null;
            }
		}
		
		internal sealed class JustCompileTopDocsCollector : TopDocsCollector<ScoreDoc>
		{

            internal JustCompileTopDocsCollector(PriorityQueue<ScoreDoc> pq)
                : base(pq)
			{
			}
			
			public override void  Collect(int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetNextReader(IndexReader reader, int docBase, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
			
			public override void  SetScorer(Scorer scorer)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override bool AcceptsDocsOutOfOrder
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }
		}
		
		[Serializable]
		internal sealed class JustCompileWeight:Weight
		{
			
			public override Explanation Explain(IndexReader reader, int doc, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override Query Query
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }

		    public override float Value
		    {
		        get { throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG); }
		    }

		    public override void  Normalize(float norm)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}

		    public override float GetSumOfSquaredWeights()
		    {
		        throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
		    }

		    public override Scorer Scorer(IndexReader reader, bool scoreDocsInOrder, bool topScorer, IState state)
			{
				throw new System.NotSupportedException(Lucene.Net.Search.JustCompileSearch.UNSUPPORTED_MSG);
			}
		}
	}
}