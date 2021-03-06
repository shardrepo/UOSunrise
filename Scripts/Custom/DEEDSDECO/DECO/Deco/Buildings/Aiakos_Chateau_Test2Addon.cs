
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class Aiakos_Chateau_Test2Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1206, -9, -7, 45}, {7, -1, -9, 25}, {1206, -9, -8, 45}// 1	2	3	
			, {22, 0, -9, 45}, {1238, -9, -8, 5}, {7, -3, -9, 25}// 4	5	6	
			, {7, -5, -9, 25}, {7, -4, -9, 25}, {1238, -8, -6, 5}// 7	8	9	
			, {22, -7, -9, 45}, {22, -8, -9, 45}, {1238, -3, -8, 5}// 10	11	12	
			, {1238, -3, -6, 5}, {22, -4, -9, 45}, {7, -2, -9, 25}// 13	14	15	
			, {7, 0, -9, 25}, {1238, -5, -6, 5}, {1238, -5, -7, 5}// 16	17	18	
			, {8, -10, -7, 5}, {1238, -5, -8, 5}, {22, -3, -9, 45}// 19	20	22	
			, {7, -8, -9, 25}, {1238, 0, -7, 5}, {1238, -8, -7, 5}// 23	24	25	
			, {7, -7, -9, 25}, {1238, -6, -7, 5}, {1238, -6, -8, 5}// 26	27	28	
			, {1238, -7, -6, 5}, {7, -1, -9, 5}, {1238, -6, -6, 5}// 29	30	31	
			, {1206, -9, -6, 45}, {1238, -7, -7, 5}, {1238, -2, -6, 5}// 32	33	34	
			, {1238, -4, -7, 5}, {1238, -4, -6, 5}, {1238, -7, -8, 5}// 35	36	37	
			, {1238, -2, -7, 5}, {21, 0, -7, 45}, {21, 0, -8, 45}// 38	39	40	
			, {7, -5, -9, 5}, {7, 0, -9, 5}, {1238, -9, -6, 25}// 41	42	43	
			, {8, 0, -6, 5}, {8, 0, -7, 5}, {7, -4, -9, 5}// 44	45	46	
			, {7, -3, -9, 5}, {7, -6, -9, 5}, {7, -8, -9, 5}// 47	48	49	
			, {1238, -8, -8, 5}, {8, -10, -8, 5}, {7, -9, -9, 25}// 50	51	52	
			, {1238, -9, -6, 5}, {8, 0, -8, 5}, {1238, 0, -8, 5}// 53	54	55	
			, {8, 0, -7, 25}, {8, -10, -8, 25}, {8, -10, -6, 25}// 56	57	58	
			, {7, -9, -9, 5}, {8, -10, -7, 25}, {7, -6, -9, 25}// 59	60	61	
			, {21, 0, -6, 45}, {1238, -9, -7, 5}, {21, -10, -8, 45}// 62	63	64	
			, {21, -10, -7, 45}, {21, -10, -6, 45}, {1238, -2, -8, 5}// 65	66	67	
			, {1238, -4, -8, 5}, {8, 0, -6, 25}, {1238, -1, -6, 5}// 68	69	70	
			, {1238, -9, -7, 25}, {1238, 0, -6, 5}, {1238, -9, -8, 25}// 71	72	73	
			, {1238, -1, -8, 5}, {22, -5, -9, 45}, {1238, -1, -7, 5}// 74	75	76	
			, {1238, -3, -7, 5}, {8, 0, -8, 25}, {1238, -8, -8, 25}// 77	78	81	
			, {1238, -8, -7, 25}, {1238, -8, -6, 25}, {1238, -7, -8, 25}// 82	83	84	
			, {1238, -7, -7, 25}, {1238, -7, -6, 25}, {1238, -6, -8, 25}// 85	86	87	
			, {1238, -6, -7, 25}, {1238, -6, -6, 25}, {1238, -5, -8, 25}// 88	89	90	
			, {1238, -5, -7, 25}, {1238, -5, -6, 25}, {1238, -4, -8, 25}// 91	92	93	
			, {1238, -4, -7, 25}, {1238, -4, -6, 25}, {1238, -3, -8, 25}// 94	95	96	
			, {1238, -3, -7, 25}, {1238, -3, -6, 25}, {1238, -2, -8, 25}// 97	98	99	
			, {1238, -2, -7, 25}, {1238, -2, -6, 25}, {1238, -1, -8, 25}// 100	101	102	
			, {1238, -1, -7, 25}, {1238, -1, -6, 25}, {1238, 0, -8, 25}// 103	104	105	
			, {1238, 0, -7, 25}, {1238, 0, -6, 25}, {22, -9, -9, 45}// 106	107	108	
			, {1206, -8, -8, 45}, {1206, -8, -7, 45}, {1206, -8, -6, 45}// 109	110	111	
			, {1206, -7, -8, 45}, {1206, -7, -7, 45}, {1206, -7, -6, 45}// 112	113	114	
			, {1206, -6, -8, 45}, {1206, -6, -7, 45}, {1206, -6, -6, 45}// 115	116	117	
			, {1206, -5, -8, 45}, {1206, -5, -7, 45}, {1206, -5, -6, 45}// 118	119	120	
			, {1206, -4, -8, 45}, {1206, -4, -7, 45}, {1206, -4, -6, 45}// 121	122	123	
			, {1206, -5, -8, 45}, {1206, -5, -7, 45}, {1206, -5, -6, 45}// 124	125	126	
			, {1206, -4, -8, 45}, {1206, -4, -7, 45}, {1206, -4, -6, 45}// 127	128	129	
			, {1206, -3, -8, 45}, {1206, -3, -7, 45}, {1206, -3, -6, 45}// 130	131	132	
			, {1206, -2, -8, 45}, {1206, -2, -7, 45}, {1206, -2, -6, 45}// 133	134	135	
			, {1206, -1, -8, 45}, {1206, -1, -7, 45}, {1206, -1, -6, 45}// 136	137	138	
			, {1206, 0, -8, 45}, {1206, 0, -7, 45}, {1206, 0, -6, 45}// 139	140	141	
			, {22, -1, -9, 45}, {22, -2, -9, 45}, {22, -6, -9, 45}// 142	143	144	
			, {1238, 0, 0, 25}, {28, -1, 9, 25}, {1238, 0, 3, 25}// 145	146	147	
			, {1238, 0, 2, 25}, {1238, 0, 1, 25}, {1238, -9, 0, 5}// 148	149	150	
			, {28, 0, 9, 5}, {1238, -1, 6, 25}, {1238, -1, -1, 5}// 151	152	153	
			, {22, -7, 6, 45}, {1238, -8, 0, 5}, {21, -10, 2, 45}// 154	155	156	
			, {28, 0, 9, 25}, {27, -2, 9, 25}, {27, -2, 8, 25}// 157	158	159	
			, {1238, -8, -4, 5}, {27, -2, 7, 25}, {28, 0, -1, 45}// 160	161	162	
			, {28, -1, -1, 45}, {8, -10, 3, 5}, {8, -10, 5, 5}// 163	164	165	
			, {21, -10, 3, 45}, {7, -4, 6, 5}, {1238, -4, 2, 5}// 166	167	168	
			, {1238, -4, 3, 5}, {1238, 0, 1, 5}, {1238, 0, 0, 5}// 169	170	171	
			, {7, -7, 6, 5}, {7, -8, 6, 5}, {22, -5, 6, 45}// 172	173	174	
			, {1238, 0, -1, 5}, {1238, -9, -2, 25}, {1238, -9, -3, 25}// 175	176	177	
			, {1238, -6, -1, 5}, {1238, -6, -2, 5}, {1238, -6, -3, 5}// 178	179	180	
			, {27, -2, 8, 45}, {1238, -6, -4, 5}, {1238, -5, -3, 5}// 181	182	183	
			, {1238, 0, 3, 5}, {1238, -5, -4, 5}, {7, -2, 6, 5}// 184	185	186	
			, {7, -3, 6, 5}, {1238, 0, 2, 5}, {1206, -1, 3, 65}// 187	188	189	
			, {1238, -5, -5, 5}, {21, -10, -2, 45}, {1238, -6, 3, 5}// 190	191	192	
			, {1238, -5, 2, 5}, {7, -9, 6, 5}, {1238, -5, 1, 5}// 193	194	195	
			, {2141, -2, 9, 5}, {2142, -10, 8, 5}, {2142, -10, 9, 5}// 196	197	198	
			, {2142, -10, 7, 5}, {2142, -10, 6, 5}, {2141, -9, 9, 5}// 199	200	201	
			, {2141, -8, 9, 5}, {1238, -5, 0, 5}, {2142, -9, 6, 5}// 202	203	204	
			, {1238, -5, -1, 5}, {8, -10, 6, 5}, {22, -8, 6, 45}// 205	206	207	
			, {27, -2, 5, 45}, {1238, -5, -2, 5}, {27, -2, 0, 45}// 208	209	210	
			, {1238, -3, -4, 5}, {8, -10, 1, 5}, {28, 0, 9, 45}// 211	212	213	
			, {8, -10, 5, 25}, {1238, -3, -5, 5}, {8, -10, 0, 5}// 214	215	216	
			, {8, -10, -2, 5}, {1238, -6, 0, 5}, {8, -10, -3, 5}// 217	218	219	
			, {1238, -6, 1, 5}, {1238, -6, 2, 5}, {8, -10, -4, 5}// 220	221	222	
			, {28, -1, 9, 45}, {8, -10, -5, 5}, {8, -10, 2, 5}// 223	224	225	
			, {27, -2, 1, 45}, {21, -10, -1, 45}, {1238, -5, 4, 5}// 226	227	228	
			, {1238, -4, -1, 5}, {37, -1, 9, 65}, {1238, -4, -2, 5}// 229	230	231	
			, {1238, -7, 3, 5}, {1238, -4, -3, 5}, {1238, -4, -4, 5}// 232	233	234	
			, {1238, -7, 2, 5}, {1238, 0, 8, 45}, {1238, -5, 6, 5}// 235	236	237	
			, {1238, -5, 5, 5}, {1238, -7, -4, 5}, {1238, -7, -5, 5}// 238	239	240	
			, {1206, 0, 9, 65}, {1238, 0, 6, 5}, {1238, 0, 5, 5}// 241	242	243	
			, {1238, -9, 5, 5}, {1238, 0, 4, 5}, {1238, -6, -5, 5}// 244	245	246	
			, {1206, 0, 8, 65}, {1238, 0, 5, 45}, {1206, -1, 7, 65}// 247	248	249	
			, {1238, -4, 4, 5}, {1206, -1, 0, 65}, {1206, -1, 1, 65}// 250	251	252	
			, {1206, -1, 2, 65}, {1238, -1, -3, 5}, {1206, -1, 6, 65}// 253	254	255	
			, {1206, -1, 5, 65}, {1206, -1, 4, 65}, {1238, -1, 0, 5}// 256	257	258	
			, {1206, -9, -2, 45}, {1206, -9, -5, 45}, {1238, -7, 0, 5}// 259	260	261	
			, {1238, -7, -1, 5}, {1238, -7, -2, 5}, {1206, 0, 5, 65}// 262	263	264	
			, {38, -2, 3, 65}, {1238, -7, -3, 5}, {1238, -1, 9, 5}// 265	266	267	
			, {1206, 0, 0, 65}, {1206, 0, 1, 65}, {1206, -1, 9, 65}// 268	269	270	
			, {38, -2, 4, 65}, {1238, -3, 3, 5}, {1238, -3, 2, 5}// 271	272	273	
			, {1238, -2, -3, 5}, {27, -2, 9, 5}, {1238, 0, 9, 25}// 274	275	276	
			, {1206, -1, 8, 65}, {1238, -8, 3, 5}, {1238, 0, 7, 5}// 277	278	279	
			, {1238, -8, 2, 5}, {1238, -8, -5, 5}, {1238, -3, 6, 5}// 280	281	282	
			, {1238, -8, 1, 5}, {1238, -2, 0, 45}, {1238, -1, 3, 45}// 283	284	285	
			, {1238, -2, -4, 5}, {1238, -1, 2, 45}, {1238, -2, -5, 5}// 286	287	288	
			, {1238, -3, -3, 5}, {1206, 0, 4, 65}, {1238, -1, 3, 5}// 289	290	291	
			, {1238, -1, 2, 5}, {1238, -1, 1, 5}, {1206, 0, 3, 65}// 292	293	294	
			, {1206, 0, 2, 65}, {1206, 0, 7, 65}, {1238, -2, 4, 5}// 295	296	297	
			, {1238, 0, -4, 5}, {1238, -2, 5, 5}, {1206, 0, 6, 65}// 298	299	300	
			, {1238, -2, 1, 5}, {1238, -1, 1, 45}, {1238, -1, 0, 45}// 301	302	303	
			, {1238, -2, 8, 45}, {1238, -1, 5, 45}, {1238, -3, 1, 5}// 304	305	306	
			, {1238, -2, 7, 45}, {1238, 0, 0, 45}, {1238, -1, 9, 45}// 307	308	309	
			, {1238, -9, -4, 25}, {1238, -1, 8, 45}, {1238, -1, 7, 45}// 310	311	312	
			, {21, -10, 1, 45}, {38, -2, 6, 65}, {1238, -1, 6, 45}// 313	314	315	
			, {38, -2, 5, 65}, {21, -10, 2, 45}, {1238, -2, 1, 45}// 316	317	318	
			, {1238, -2, 2, 45}, {21, -10, 6, 45}, {1238, -2, 3, 45}// 319	320	321	
			, {1238, -1, 8, 5}, {21, -10, 5, 45}, {21, -10, 4, 45}// 322	323	324	
			, {1238, -2, 4, 45}, {1238, -9, 4, 5}, {8, -10, 3, 25}// 325	326	327	
			, {8, -10, 4, 25}, {27, -2, 9, 45}, {1238, -2, 6, 45}// 328	329	330	
			, {1238, -2, 5, 45}, {1238, -9, 6, 5}, {1238, 0, 6, 25}// 331	332	333	
			, {22, -6, 6, 45}, {2182, 0, 1, 25}, {21, -10, 1, 45}// 334	335	336	
			, {1994, -9, 7, 5}, {1994, -9, 8, 5}, {1238, -1, 7, 25}// 337	338	339	
			, {21, -10, -1, 45}, {21, -10, 0, 45}, {1994, -4, 8, 5}// 340	341	342	
			, {1994, -4, 9, 5}, {37, 0, 9, 65}, {1994, -3, 7, 5}// 343	344	345	
			, {1238, -1, 7, 5}, {1238, 0, 9, 5}, {1238, 0, 8, 5}// 346	347	348	
			, {1994, -3, 8, 5}, {1994, -8, 9, 5}, {1994, -8, 8, 5}// 349	350	351	
			, {1994, -8, 7, 5}, {8, 0, -2, 5}, {7, -3, 6, 25}// 352	354	356	
			, {1238, -9, -5, 25}, {1238, -2, 2, 5}, {1238, -1, 8, 25}// 357	358	359	
			, {1238, 0, 3, 45}, {1994, -9, 9, 5}, {1994, -6, 8, 5}// 360	361	362	
			, {1994, -6, 7, 5}, {1238, -8, 5, 5}, {1994, -7, 9, 5}// 363	364	365	
			, {1994, -7, 8, 5}, {1994, -7, 7, 5}, {21, -10, -2, 45}// 366	367	368	
			, {1994, -5, 9, 5}, {1994, -5, 8, 5}, {1238, -8, 4, 5}// 369	370	371	
			, {1994, -5, 7, 5}, {1994, -6, 9, 5}, {7, -2, 6, 25}// 372	373	374	
			, {1238, -4, 0, 5}, {1238, -3, -1, 5}, {27, -2, 4, 45}// 375	376	377	
			, {1238, -3, 0, 5}, {1994, -4, 7, 5}, {1238, -6, 6, 5}// 378	379	380	
			, {38, -2, 7, 65}, {1238, -9, -4, 5}, {1238, -8, -2, 5}// 381	382	383	
			, {8, 0, -1, 5}, {8, -10, 6, 25}, {27, -2, 7, 5}// 384	385	386	
			, {1238, -1, 5, 5}, {1238, 0, 2, 45}, {38, -2, 9, 65}// 387	388	389	
			, {1238, -9, -5, 5}, {28, -1, 9, 5}, {7, -9, 6, 25}// 390	391	392	
			, {1238, -9, -3, 5}, {1238, -7, 6, 5}, {1238, 0, 4, 25}// 393	394	395	
			, {1238, 0, 5, 25}, {1238, -7, 5, 5}, {1238, 0, 7, 45}// 396	397	398	
			, {1238, -2, 6, 5}, {1238, 0, -5, 5}, {21, 0, -3, 45}// 399	400	401	
			, {1238, 0, -3, 5}, {1238, -2, 3, 5}, {1238, -1, 1, 25}// 402	403	404	
			, {7, -4, 6, 25}, {1238, -6, 5, 5}, {1238, -6, 4, 5}// 405	406	407	
			, {7, -5, 6, 25}, {7, -6, 6, 25}, {7, -7, 6, 25}// 408	409	410	
			, {1238, -8, 6, 5}, {1238, -9, -1, 5}, {1238, -7, 4, 5}// 411	412	413	
			, {7, -8, 6, 25}, {1238, -9, -2, 5}, {1994, -2, 7, 5}// 414	415	416	
			, {1238, -3, 5, 5}, {1238, -3, 4, 5}, {1238, -1, 4, 25}// 417	418	419	
			, {1238, -4, 6, 5}, {8, 0, -3, 5}, {1238, -4, 5, 5}// 420	421	422	
			, {1238, 0, 9, 45}, {1238, -1, 0, 25}, {1238, -1, 9, 25}// 423	424	425	
			, {27, -2, 6, 45}, {2141, -3, 9, 5}, {1238, -2, 0, 5}// 426	427	428	
			, {1994, -3, 9, 5}, {2141, -4, 9, 5}, {1238, -1, 6, 5}// 429	430	431	
			, {1238, -2, -2, 5}, {1238, -1, -2, 5}, {21, 0, -2, 45}// 432	433	434	
			, {1238, -1, 2, 25}, {1238, -1, 3, 25}, {1238, -1, 5, 25}// 435	436	437	
			, {1238, 0, 6, 45}, {1238, 0, 8, 25}, {8, 0, -3, 25}// 438	439	440	
			, {1238, 0, -2, 5}, {1238, 0, 7, 25}, {1238, 0, 4, 45}// 441	442	443	
			, {8, 0, -5, 25}, {1238, -1, 4, 5}, {8, 0, -1, 25}// 444	445	446	
			, {1238, -9, 3, 5}, {1238, -9, 2, 5}, {8, -10, -1, 25}// 447	448	449	
			, {21, 0, -3, 45}, {8, -10, -2, 25}, {2141, -6, 9, 5}// 450	451	452	
			, {2141, -7, 9, 5}, {1238, -3, -2, 5}, {1238, -7, 1, 5}// 453	454	455	
			, {1238, -9, 1, 5}, {1238, -1, 4, 45}, {22, -2, 6, 45}// 456	457	458	
			, {1994, -2, 8, 5}, {1238, 0, 1, 45}, {1238, -2, -1, 5}// 459	460	461	
			, {8, -10, -3, 25}, {1238, -5, 3, 5}, {1238, -4, -5, 5}// 462	463	464	
			, {1994, -2, 9, 5}, {21, 0, -5, 45}, {8, -10, -4, 25}// 465	466	467	
			, {1238, -8, -3, 5}, {37, -1, -1, 65}, {38, -2, 8, 65}// 468	469	470	
			, {2141, -5, 9, 5}, {22, -2, 7, 45}, {27, -2, 7, 45}// 471	472	473	
			, {21, -10, -5, 45}, {8, -10, -5, 25}, {37, 0, -1, 65}// 474	475	476	
			, {8, 0, -4, 25}, {8, -10, 4, 25}, {8, 0, -2, 25}// 477	478	479	
			, {1206, -9, -1, 45}, {8, -10, 2, 25}, {1238, -1, -4, 5}// 480	481	482	
			, {1238, -1, -5, 5}, {1238, -8, -1, 5}, {8, -10, 1, 25}// 483	484	485	
			, {8, -10, 0, 25}, {38, -2, 0, 65}, {1238, -4, 1, 5}// 486	487	488	
			, {38, -2, 1, 65}, {38, -2, 2, 65}, {1206, -9, -4, 45}// 489	490	491	
			, {22, -3, 6, 45}, {22, -9, 6, 45}, {1206, -9, -3, 45}// 492	493	494	
			, {21, 0, -4, 45}, {21, -10, -4, 45}, {21, -10, -3, 45}// 495	496	497	
			, {27, -2, 8, 5}, {1238, -9, -1, 25}, {1238, -9, 0, 25}// 498	499	500	
			, {1238, -9, 1, 25}, {1238, -9, 2, 25}, {1238, -9, 3, 25}// 501	502	503	
			, {1238, -9, 4, 25}, {1238, -9, 5, 25}, {1238, -9, 6, 25}// 504	505	506	
			, {1238, -8, -5, 25}, {1238, -8, -4, 25}, {1238, -8, -3, 25}// 507	508	509	
			, {1238, -8, -2, 25}, {1238, -8, -1, 25}, {1238, -8, 0, 25}// 510	511	512	
			, {1238, -8, 1, 25}, {1238, -8, 2, 25}, {1238, -8, 3, 25}// 513	514	515	
			, {1238, -8, 4, 25}, {1238, -8, 5, 25}, {1238, -8, 6, 25}// 516	517	518	
			, {1238, -7, -5, 25}, {1238, -7, -4, 25}, {1238, -7, -3, 25}// 519	520	521	
			, {1238, -7, -2, 25}, {1238, -7, -1, 25}, {1238, -7, 0, 25}// 522	523	524	
			, {1238, -7, 1, 25}, {1238, -7, 2, 25}, {1238, -7, 3, 25}// 525	526	527	
			, {1238, -7, 4, 25}, {1238, -7, 5, 25}, {1238, -7, 6, 25}// 528	529	530	
			, {1238, -6, -5, 25}, {1238, -6, -4, 25}, {1238, -6, -3, 25}// 531	532	533	
			, {1238, -6, -2, 25}, {1238, -6, -1, 25}, {1238, -6, 0, 25}// 534	535	536	
			, {1238, -6, 1, 25}, {1238, -6, 2, 25}, {1238, -6, 3, 25}// 537	538	539	
			, {1238, -6, 4, 25}, {1238, -6, 5, 25}, {1238, -6, 6, 25}// 540	541	542	
			, {1238, -5, -5, 25}, {1238, -5, -4, 25}, {1238, -5, -3, 25}// 543	544	545	
			, {1238, -5, -2, 25}, {1238, -5, -1, 25}, {1238, -5, 0, 25}// 546	547	548	
			, {1238, -5, 1, 25}, {1238, -5, 2, 25}, {1238, -5, 3, 25}// 549	550	551	
			, {1238, -5, 4, 25}, {1238, -5, 5, 25}, {1238, -5, 6, 25}// 552	553	554	
			, {1238, -4, -5, 25}, {1238, -4, -4, 25}, {1238, -4, -3, 25}// 555	556	557	
			, {1238, -4, -2, 25}, {1238, -4, -1, 25}, {1238, -4, 0, 25}// 558	559	560	
			, {1238, -4, 1, 25}, {1238, -4, 2, 25}, {1238, -4, 3, 25}// 561	562	563	
			, {1238, -4, 4, 25}, {1238, -4, 5, 25}, {1238, -4, 6, 25}// 564	565	566	
			, {1238, -3, -5, 25}, {1238, -3, -4, 25}, {1238, -3, -3, 25}// 567	568	569	
			, {1238, -3, -2, 25}, {1238, -3, -1, 25}, {1238, -3, 0, 25}// 570	571	572	
			, {1238, -3, 1, 25}, {1238, -3, 2, 25}, {1238, -3, 3, 25}// 573	574	575	
			, {1238, -3, 4, 25}, {1238, -3, 5, 25}, {1238, -3, 6, 25}// 576	577	578	
			, {1238, -2, -5, 25}, {1238, -2, -4, 25}, {1238, -2, -3, 25}// 579	580	581	
			, {1238, -2, -2, 25}, {1238, -2, -1, 25}, {1238, -2, 0, 25}// 582	583	584	
			, {1238, -2, 1, 25}, {1238, -2, 2, 25}, {1238, -2, 3, 25}// 585	586	587	
			, {1238, -2, 4, 25}, {1238, -2, 5, 25}, {1238, -2, 6, 25}// 588	589	590	
			, {1238, -1, -5, 25}, {1238, -1, -4, 25}, {1238, -1, -3, 25}// 591	592	593	
			, {1238, -1, -2, 25}, {1238, -1, -1, 25}, {1238, -1, 0, 25}// 594	595	596	
			, {1238, -1, 1, 25}, {1238, -1, 2, 25}, {1238, -1, 3, 25}// 597	598	599	
			, {1238, -1, 4, 25}, {1238, -1, 5, 25}, {1238, -1, 6, 25}// 600	601	602	
			, {1238, 0, -5, 25}, {1238, 0, -4, 25}, {1238, 0, -3, 25}// 603	604	605	
			, {1238, 0, -2, 25}, {1238, 0, -1, 25}, {1238, 0, 0, 25}// 606	607	608	
			, {1238, 0, 1, 25}, {1238, 0, 2, 25}, {1238, 0, 3, 25}// 609	610	611	
			, {1238, 0, 4, 25}, {1238, 0, 5, 25}, {1238, 0, 6, 25}// 612	613	614	
			, {1206, -9, 0, 45}, {1206, -9, 1, 45}, {1206, -9, 2, 45}// 615	616	617	
			, {1206, -9, 3, 45}, {1206, -9, 4, 45}, {1206, -9, 5, 45}// 618	619	620	
			, {1206, -9, 6, 45}, {1206, -8, -5, 45}, {1206, -8, -4, 45}// 621	622	623	
			, {1206, -8, -3, 45}, {1206, -8, -2, 45}, {1206, -8, -1, 45}// 624	625	626	
			, {1206, -8, 0, 45}, {1206, -8, 1, 45}, {1206, -8, 2, 45}// 627	628	629	
			, {1206, -8, 3, 45}, {1206, -8, 4, 45}, {1206, -8, 5, 45}// 630	631	632	
			, {1206, -8, 6, 45}, {1206, -7, -5, 45}, {1206, -7, -4, 45}// 633	634	635	
			, {1206, -7, -3, 45}, {1206, -7, -2, 45}, {1206, -7, -1, 45}// 636	637	638	
			, {1206, -7, 0, 45}, {1206, -7, 1, 45}, {1206, -7, 2, 45}// 639	640	641	
			, {1206, -7, 3, 45}, {1206, -7, 4, 45}, {1206, -7, 5, 45}// 642	643	644	
			, {1206, -7, 6, 45}, {1206, -6, -5, 45}, {1206, -6, -4, 45}// 645	646	647	
			, {1206, -6, -3, 45}, {1206, -6, -2, 45}, {1206, -6, -1, 45}// 648	649	650	
			, {1206, -6, 0, 45}, {1206, -6, 1, 45}, {1206, -6, 2, 45}// 651	652	653	
			, {1206, -6, 3, 45}, {1206, -6, 4, 45}, {1206, -6, 5, 45}// 654	655	656	
			, {1206, -6, 6, 45}, {1206, -5, -5, 45}, {1206, -5, -4, 45}// 657	658	659	
			, {1206, -5, -3, 45}, {1206, -5, -2, 45}, {1206, -5, -1, 45}// 660	661	662	
			, {1206, -5, 0, 45}, {1206, -5, 1, 45}, {1206, -5, 2, 45}// 663	664	665	
			, {1206, -5, 3, 45}, {1206, -5, 4, 45}, {1206, -5, 5, 45}// 666	667	668	
			, {1206, -5, 6, 45}, {1206, -4, -5, 45}, {1206, -4, -4, 45}// 669	670	671	
			, {1206, -4, -3, 45}, {1206, -4, -2, 45}, {1206, -4, -1, 45}// 672	673	674	
			, {1206, -4, 0, 45}, {1206, -4, 1, 45}, {1206, -4, 2, 45}// 675	676	677	
			, {1206, -4, 3, 45}, {1206, -4, 4, 45}, {1206, -4, 5, 45}// 678	679	680	
			, {1206, -4, 6, 45}, {2182, 0, 0, 25}, {1206, -5, -5, 45}// 681	682	683	
			, {1206, -5, -4, 45}, {1206, -5, -3, 45}, {1206, -5, -2, 45}// 684	685	686	
			, {1206, -5, -1, 45}, {1206, -5, 0, 45}, {1206, -5, 1, 45}// 687	688	689	
			, {1206, -5, 2, 45}, {1206, -5, 3, 45}, {1206, -5, 4, 45}// 690	691	692	
			, {1206, -5, 5, 45}, {1206, -5, 6, 45}, {1206, -4, -5, 45}// 693	694	695	
			, {1206, -4, -4, 45}, {1206, -4, -3, 45}, {1206, -4, -2, 45}// 696	697	698	
			, {1206, -4, -1, 45}, {1206, -4, 0, 45}, {1206, -4, 1, 45}// 699	700	701	
			, {1206, -4, 2, 45}, {1206, -4, 3, 45}, {1206, -4, 4, 45}// 702	703	704	
			, {1206, -4, 5, 45}, {1206, -4, 6, 45}, {1206, -3, -5, 45}// 705	706	707	
			, {1206, -3, -4, 45}, {1206, -3, -3, 45}, {1206, -3, -2, 45}// 708	709	710	
			, {1206, -3, -1, 45}, {1206, -3, 0, 45}, {1206, -3, 1, 45}// 711	712	713	
			, {1206, -3, 2, 45}, {1206, -3, 3, 45}, {1206, -3, 4, 45}// 714	715	716	
			, {1206, -3, 5, 45}, {1206, -3, 6, 45}, {1206, -2, -5, 45}// 717	718	719	
			, {1206, -2, -4, 45}, {1206, -2, -3, 45}, {1206, -2, -2, 45}// 720	721	722	
			, {1206, -2, -1, 45}, {1206, -2, 0, 45}, {1206, -2, 1, 45}// 723	724	725	
			, {1206, -2, 2, 45}, {1206, -2, 3, 45}, {1206, -2, 4, 45}// 726	727	728	
			, {1206, -2, 5, 45}, {1206, -2, 6, 45}, {1206, -1, -5, 45}// 729	730	731	
			, {1206, -1, -4, 45}, {1206, -1, -3, 45}, {1206, -1, -2, 45}// 732	733	734	
			, {1206, -1, -1, 45}, {1206, 0, -5, 45}, {1206, 0, -4, 45}// 735	736	737	
			, {1206, 0, -3, 45}, {1206, 0, -2, 45}, {1206, 0, -1, 45}// 738	739	740	
			, {22, -4, 6, 45}, {21, -10, 0, 45}, {2141, 2, -9, 5}// 741	742	743	
			, {2141, 4, -9, 5}, {2141, 5, -9, 5}, {1998, 1, -7, 5}// 744	745	746	
			, {2142, 8, -8, 5}, {2141, 1, -9, 5}, {1998, 1, -8, 5}// 747	748	749	
			, {2141, 3, -9, 5}, {2142, 8, -6, 5}, {2142, 8, -7, 5}// 750	751	752	
			, {2141, 8, -9, 5}, {2141, 7, -9, 5}, {2141, 6, -9, 5}// 753	754	755	
			, {1998, 1, -6, 5}, {1998, 2, -8, 5}, {1998, 2, -7, 5}// 756	757	758	
			, {1998, 2, -6, 5}, {1998, 3, -8, 5}, {1998, 3, -7, 5}// 759	760	761	
			, {1998, 3, -6, 5}, {1998, 4, -8, 5}, {1998, 4, -7, 5}// 762	763	764	
			, {1998, 4, -6, 5}, {1998, 5, -8, 5}, {1998, 5, -7, 5}// 765	766	767	
			, {1998, 5, -6, 5}, {1998, 6, -8, 5}, {1998, 6, -7, 5}// 768	769	770	
			, {1998, 6, -6, 5}, {1998, 7, -8, 5}, {1998, 7, -7, 5}// 771	772	773	
			, {1998, 7, -6, 5}, {1998, 8, -8, 5}, {1998, 8, -7, 5}// 774	775	776	
			, {1998, 8, -6, 5}, {27, 8, 2, 25}, {1848, 3, 1, 10}// 777	778	779	
			, {28, 4, -1, 45}, {1238, 6, 1, 5}, {28, 7, -1, 45}// 780	781	782	
			, {1848, 3, 8, 25}, {27, 8, 0, 25}, {1848, 2, 7, 35}// 783	784	785	
			, {28, 5, -1, 45}, {1238, 5, 8, 5}, {1238, 5, 9, 5}// 786	787	788	
			, {28, 6, -1, 45}, {27, 8, 0, 45}, {38, 8, 3, 65}// 789	790	791	
			, {1238, 2, 6, 5}, {28, 7, 9, 5}, {27, 8, 9, 25}// 792	793	794	
			, {1238, 3, 6, 45}, {28, 6, 9, 5}, {27, 8, 7, 25}// 795	796	797	
			, {1238, 7, 8, 25}, {28, 6, 9, 25}, {28, 4, 9, 25}// 798	799	800	
			, {28, 3, 9, 25}, {2178, 4, 1, 22}, {1238, 7, 9, 25}// 801	802	803	
			, {1238, 8, 0, 25}, {1238, 1, 5, 45}, {28, 2, 9, 25}// 804	805	806	
			, {1238, 6, 5, 25}, {28, 2, -1, 45}, {28, 3, -1, 45}// 808	811	812	
			, {1206, 1, 6, 65}, {2142, 8, -3, 5}, {2142, 8, -2, 5}// 813	814	815	
			, {27, 8, 7, 5}, {27, 8, 3, 5}, {1238, 6, 7, 25}// 816	817	818	
			, {28, 8, 9, 25}, {28, 7, 9, 25}, {1848, 3, 0, 10}// 819	820	821	
			, {1848, 3, 8, 30}, {1848, 5, 0, 5}, {27, 8, 9, 5}// 822	823	824	
			, {1848, 1, 8, 25}, {27, 8, 6, 5}, {1238, 1, 1, 5}// 825	826	827	
			, {1238, 1, 0, 5}, {1238, 2, 4, 45}, {26, 8, 9, 45}// 828	829	831	
			, {1238, 4, 2, 5}, {1238, 1, 4, 45}, {1238, 7, 5, 25}// 832	833	834	
			, {1238, 7, 6, 25}, {1238, 1, 3, 25}, {1238, 1, 2, 25}// 835	836	837	
			, {1238, 1, 9, 5}, {1238, 8, 2, 25}, {1206, 1, 9, 65}// 838	839	840	
			, {27, 8, 2, 5}, {1998, 1, -5, 5}, {1238, 1, 9, 25}// 842	843	844	
			, {2183, 6, 9, 45}, {1238, 7, 0, 25}, {27, 8, 4, 25}// 845	846	847	
			, {1238, 6, 2, 25}, {1238, 6, 3, 25}, {1238, 6, 1, 25}// 848	849	850	
			, {1238, 3, 8, 25}, {1238, 3, 7, 25}, {1998, 1, -4, 5}// 851	852	853	
			, {1848, 2, 0, 5}, {1206, 1, 7, 65}, {1238, 3, 3, 45}// 854	855	856	
			, {28, 4, -1, 25}, {28, 5, -1, 25}, {1238, 3, 4, 45}// 857	858	859	
			, {28, 3, -1, 25}, {28, 2, -1, 25}, {28, 7, 9, 45}// 860	861	862	
			, {28, 8, -1, 45}, {1238, 1, 7, 45}, {28, 6, 9, 45}// 863	864	865	
			, {28, 8, -1, 25}, {1238, 1, 7, 5}, {28, 7, -1, 25}// 866	867	868	
			, {28, 6, -1, 25}, {1238, 5, 2, 5}, {1238, 3, 1, 45}// 869	870	871	
			, {1238, 1, 6, 5}, {1238, 6, 4, 25}, {1238, 2, 4, 25}// 872	873	874	
			, {1238, 2, 2, 25}, {28, 3, 9, 5}, {28, 2, 9, 5}// 875	876	878	
			, {1848, 1, 8, 30}, {1238, 8, 1, 25}, {1238, 1, 2, 5}// 879	880	881	
			, {1238, 2, 5, 45}, {1238, 1, 3, 5}, {1238, 1, 4, 5}// 882	883	884	
			, {1238, 1, 5, 5}, {1238, 4, 8, 5}, {1206, 1, 0, 65}// 885	886	887	
			, {1238, 4, 7, 5}, {1238, 4, 0, 5}, {38, 8, 4, 65}// 888	889	890	
			, {27, 8, 4, 45}, {2174, 4, 7, 32}, {1206, 1, 4, 65}// 891	892	893	
			, {1206, 1, 3, 65}, {1872, 9, 5, 2}, {28, 4, 9, 45}// 894	895	896	
			, {1206, 1, 1, 65}, {1206, 1, 2, 65}, {1238, 1, 1, 45}// 897	898	899	
			, {1238, 4, 1, 5}, {1238, 4, 6, 5}, {1238, 4, 5, 5}// 900	901	902	
			, {1238, 4, 4, 5}, {1206, 1, 5, 65}, {1238, 2, 7, 5}// 903	904	905	
			, {1238, 4, 3, 5}, {2176, 2, 1, 25}, {1848, 2, 7, 30}// 906	907	908	
			, {1848, 1, 7, 40}, {1848, 1, 8, 40}, {1850, 5, 8, 25}// 909	910	911	
			, {1850, 5, 7, 25}, {1850, 4, 8, 30}, {1238, 4, 1, 45}// 912	913	914	
			, {1238, 5, 3, 5}, {1878, 10, 6, 0}, {2174, 3, 7, 37}// 915	916	917	
			, {28, 1, -1, 25}, {2176, 1, 1, 25}, {1206, 1, 8, 65}// 918	919	920	
			, {1848, 2, 8, 35}, {1238, 3, 2, 5}, {1852, 1, 0, 5}// 921	922	923	
			, {1238, 3, 8, 5}, {28, 1, -1, 5}, {1874, 10, 5, 0}// 924	925	926	
			, {26, 8, 9, 5}, {28, 2, -1, 5}, {1238, 3, 9, 5}// 927	928	929	
			, {1848, 1, 8, 35}, {1848, 1, 7, 35}, {1238, 5, 7, 5}// 930	931	932	
			, {1848, 1, 8, 30}, {1850, 3, 7, 35}, {1238, 5, 7, 25}// 933	934	935	
			, {1238, 3, 6, 5}, {1238, 3, 9, 25}, {2176, 2, 6, 45}// 936	937	938	
			, {2176, 3, 6, 45}, {1238, 5, 6, 25}, {1238, 5, 5, 25}// 939	940	941	
			, {2176, 4, 6, 45}, {2176, 5, 6, 45}, {1238, 3, 1, 5}// 942	943	944	
			, {1238, 5, 8, 25}, {1238, 3, 5, 5}, {1238, 5, 3, 25}// 945	946	947	
			, {1238, 5, 9, 25}, {2183, 6, 7, 45}, {1238, 2, 3, 5}// 948	949	950	
			, {37, 8, -1, 65}, {37, 7, -1, 65}, {1238, 7, 4, 25}// 951	952	953	
			, {1238, 7, 3, 25}, {1238, 7, 2, 25}, {28, 4, -1, 5}// 954	955	956	
			, {1848, 1, 8, 25}, {1238, 5, 5, 5}, {1238, 3, 4, 5}// 957	958	959	
			, {1238, 7, 1, 25}, {37, 6, -1, 65}, {1238, 5, 6, 5}// 960	961	962	
			, {2142, 8, -1, 5}, {38, 8, 2, 65}, {38, 8, 1, 65}// 963	964	965	
			, {38, 8, 0, 65}, {1238, 2, 6, 25}, {37, 3, 9, 65}// 966	967	969	
			, {1848, 4, 8, 25}, {1238, 2, 5, 25}, {1238, 2, 8, 25}// 971	972	973	
			, {1238, 2, 7, 25}, {1848, 5, 1, 20}, {1238, 2, 9, 25}// 974	975	976	
			, {1848, 5, 1, 15}, {1238, 2, 3, 25}, {1848, 5, 0, 15}// 977	978	979	
			, {1238, 3, 5, 25}, {28, 4, 9, 5}, {1238, 3, 4, 25}// 980	981	982	
			, {1848, 2, 8, 25}, {27, 8, 5, 45}, {27, 8, 7, 45}// 983	984	985	
			, {1848, 2, 8, 25}, {1848, 5, 1, 10}, {1238, 2, 2, 45}// 986	987	988	
			, {1848, 5, 0, 10}, {1238, 2, 3, 45}, {1238, 2, 1, 45}// 989	990	991	
			, {1238, 2, 0, 45}, {1238, 3, 3, 25}, {1238, 5, 0, 5}// 992	993	994	
			, {1850, 2, 7, 40}, {27, 8, 0, 5}, {1238, 1, 8, 25}// 995	996	998	
			, {1875, 9, 3, 1}, {1238, 3, 2, 45}, {27, 8, 2, 45}// 1000	1001	1002	
			, {1238, 3, 2, 25}, {1238, 5, 1, 25}, {1238, 5, 4, 25}// 1003	1004	1005	
			, {1238, 4, 5, 25}, {1238, 4, 6, 25}, {28, 5, -1, 5}// 1006	1007	1008	
			, {1874, 10, 4, 0}, {1848, 5, 1, 5}, {28, 3, -1, 5}// 1009	1011	1012	
			, {1238, 4, 4, 25}, {28, 8, -1, 5}, {28, 1, -1, 45}// 1013	1014	1015	
			, {28, 7, -1, 5}, {1852, 1, 1, 5}, {1873, 9, 6, 1}// 1016	1017	1018	
			, {1238, 4, 3, 25}, {1238, 6, 8, 25}, {1238, 4, 2, 25}// 1019	1020	1021	
			, {1848, 5, 0, 20}, {1238, 3, 3, 5}, {1848, 4, 0, 5}// 1022	1023	1024	
			, {1848, 3, 1, 5}, {1238, 1, 0, 45}, {1238, 1, 9, 45}// 1025	1026	1027	
			, {1238, 5, 4, 5}, {28, 6, -1, 5}, {1238, 1, 6, 25}// 1028	1029	1030	
			, {1238, 1, 5, 25}, {1238, 1, 4, 25}, {1238, 3, 6, 25}// 1031	1032	1033	
			, {1238, 5, 2, 25}, {1238, 4, 9, 25}, {1238, 5, 0, 25}// 1034	1035	1036	
			, {1852, 4, 0, 20}, {1238, 4, 7, 25}, {1238, 4, 8, 25}// 1037	1039	1040	
			, {1238, 3, 0, 45}, {1238, 7, 7, 25}, {1850, 4, 7, 30}// 1041	1042	1043	
			, {1238, 2, 2, 5}, {1238, 6, 0, 5}, {1238, 1, 8, 45}// 1044	1046	1047	
			, {1852, 4, 1, 20}, {27, 8, 5, 25}, {38, 8, 7, 65}// 1048	1049	1050	
			, {28, 3, 9, 45}, {1238, 1, 7, 25}, {28, 2, 9, 45}// 1051	1052	1053	
			, {1206, 2, 0, 65}, {1238, 1, 7, 5}, {38, 8, 5, 65}// 1054	1055	1056	
			, {1848, 2, 1, 5}, {1238, 1, 8, 5}, {2178, 3, 1, 17}// 1057	1058	1059	
			, {1998, 1, -3, 5}, {1238, 4, 9, 5}, {1998, 1, -2, 5}// 1060	1061	1062	
			, {1238, 6, 2, 5}, {1238, 5, 1, 5}, {1238, 1, 2, 45}// 1063	1064	1065	
			, {1238, 1, 3, 45}, {1238, 6, 0, 25}, {1238, 1, 6, 45}// 1066	1067	1068	
			, {37, 1, 9, 65}, {1238, 3, 5, 45}, {1238, 2, 4, 5}// 1069	1071	1072	
			, {1238, 2, 5, 5}, {1238, 2, 8, 5}, {1238, 2, 9, 5}// 1073	1075	1076	
			, {1238, 2, 1, 5}, {1238, 3, 0, 5}, {1238, 2, 0, 5}// 1077	1078	1079	
			, {1238, 1, 9, 5}, {1238, 1, 8, 5}, {1238, 3, 7, 5}// 1080	1081	1082	
			, {1238, 6, 9, 25}, {37, 8, 9, 65}, {1852, 3, 1, 15}// 1083	1084	1085	
			, {37, 7, 9, 65}, {37, 6, 9, 65}, {37, 5, 9, 65}// 1086	1087	1088	
			, {37, 4, 9, 65}, {37, 1, -1, 65}, {2142, 8, -5, 5}// 1089	1090	1091	
			, {37, 4, -1, 65}, {37, 3, -1, 65}, {1238, 4, 0, 45}// 1092	1093	1094	
			, {37, 2, -1, 65}, {1238, 6, 6, 25}, {2142, 8, -4, 5}// 1095	1096	1097	
			, {37, 5, -1, 65}, {2176, 4, 1, 25}, {1848, 4, 8, 25}// 1098	1099	1100	
			, {2174, 4, 7, 32}, {1238, 6, 3, 5}, {1238, 6, 4, 5}// 1101	1102	1103	
			, {1238, 6, 5, 5}, {1238, 6, 6, 5}, {1238, 6, 7, 5}// 1104	1105	1106	
			, {1238, 6, 8, 5}, {1238, 6, 9, 5}, {1238, 7, 0, 5}// 1107	1108	1109	
			, {1238, 7, 1, 5}, {1238, 7, 2, 5}, {1238, 7, 3, 5}// 1110	1111	1112	
			, {1238, 7, 4, 5}, {1238, 7, 5, 5}, {1238, 7, 6, 5}// 1113	1114	1115	
			, {1238, 7, 7, 5}, {1238, 7, 8, 5}, {1238, 7, 9, 5}// 1116	1117	1118	
			, {1238, 8, 0, 5}, {1238, 8, 1, 5}, {1238, 8, 2, 5}// 1119	1120	1121	
			, {1238, 8, 3, 5}, {1238, 8, 4, 5}, {1238, 8, 5, 5}// 1122	1123	1124	
			, {1238, 8, 6, 5}, {1238, 8, 7, 5}, {1238, 8, 8, 5}// 1125	1126	1127	
			, {1238, 8, 9, 5}, {1238, 8, 3, 25}, {1238, 8, 4, 25}// 1128	1129	1130	
			, {1238, 8, 5, 25}, {1238, 8, 6, 25}, {1238, 8, 7, 25}// 1131	1132	1133	
			, {1238, 8, 8, 25}, {1238, 8, 9, 25}, {1238, 4, 2, 45}// 1134	1135	1136	
			, {1238, 4, 3, 45}, {1238, 4, 4, 45}, {1238, 4, 5, 45}// 1137	1138	1139	
			, {1238, 4, 6, 45}, {1238, 5, 0, 45}, {1238, 5, 1, 45}// 1140	1141	1142	
			, {1238, 5, 2, 45}, {1238, 5, 3, 45}, {1238, 5, 4, 45}// 1143	1144	1145	
			, {1238, 5, 5, 45}, {1238, 5, 6, 45}, {1238, 6, 0, 45}// 1146	1147	1148	
			, {1238, 6, 1, 45}, {1238, 6, 2, 45}, {1238, 6, 3, 45}// 1149	1150	1151	
			, {1238, 6, 4, 45}, {1238, 6, 5, 45}, {1238, 6, 6, 45}// 1152	1153	1154	
			, {1238, 6, 7, 45}, {1238, 6, 8, 45}, {1238, 6, 9, 45}// 1155	1156	1157	
			, {1238, 7, 0, 45}, {1238, 7, 1, 45}, {1238, 7, 2, 45}// 1158	1159	1160	
			, {1238, 7, 3, 45}, {1238, 7, 4, 45}, {1238, 7, 5, 45}// 1161	1162	1163	
			, {1238, 7, 6, 45}, {1238, 7, 7, 45}, {1238, 7, 8, 45}// 1164	1165	1166	
			, {1238, 7, 9, 45}, {1238, 8, 0, 45}, {1238, 8, 1, 45}// 1167	1168	1169	
			, {1238, 8, 2, 45}, {1238, 8, 3, 45}, {1238, 8, 4, 45}// 1170	1171	1172	
			, {1238, 8, 5, 45}, {1238, 8, 6, 45}, {1238, 8, 7, 45}// 1173	1174	1175	
			, {1238, 8, 8, 45}, {1238, 8, 9, 45}, {1206, 2, 1, 65}// 1176	1177	1178	
			, {1206, 2, 2, 65}, {1206, 2, 3, 65}, {1206, 2, 4, 65}// 1179	1180	1181	
			, {1206, 2, 5, 65}, {1206, 2, 6, 65}, {1206, 2, 7, 65}// 1182	1183	1184	
			, {1206, 2, 8, 65}, {1206, 2, 9, 65}, {1206, 3, 0, 65}// 1185	1186	1187	
			, {1206, 3, 1, 65}, {1206, 3, 2, 65}, {1206, 3, 3, 65}// 1188	1189	1190	
			, {1206, 3, 4, 65}, {1206, 3, 5, 65}, {1206, 3, 6, 65}// 1191	1192	1193	
			, {1206, 3, 7, 65}, {1206, 3, 8, 65}, {1206, 3, 9, 65}// 1194	1195	1196	
			, {1206, 4, 0, 65}, {1206, 4, 1, 65}, {1206, 4, 2, 65}// 1197	1198	1199	
			, {1206, 4, 3, 65}, {1206, 4, 4, 65}, {1206, 4, 5, 65}// 1200	1201	1202	
			, {1206, 4, 6, 65}, {1206, 4, 7, 65}, {1206, 4, 8, 65}// 1203	1204	1205	
			, {1206, 4, 9, 65}, {1206, 5, 0, 65}, {1206, 5, 1, 65}// 1206	1207	1208	
			, {1206, 5, 2, 65}, {1206, 5, 3, 65}, {1206, 5, 4, 65}// 1209	1210	1211	
			, {1206, 5, 5, 65}, {1206, 5, 6, 65}, {1206, 5, 7, 65}// 1212	1213	1214	
			, {1206, 5, 8, 65}, {1206, 5, 9, 65}, {1206, 6, 0, 65}// 1215	1216	1217	
			, {1206, 6, 1, 65}, {1206, 6, 2, 65}, {1206, 6, 3, 65}// 1218	1219	1220	
			, {1206, 6, 4, 65}, {1206, 6, 5, 65}, {1206, 6, 6, 65}// 1221	1222	1223	
			, {1206, 6, 7, 65}, {1206, 6, 8, 65}, {1206, 6, 9, 65}// 1224	1225	1226	
			, {1206, 7, 0, 65}, {1206, 7, 1, 65}, {1206, 7, 2, 65}// 1227	1228	1229	
			, {1206, 7, 3, 65}, {1206, 7, 4, 65}, {1206, 7, 5, 65}// 1230	1231	1232	
			, {1206, 7, 6, 65}, {1206, 7, 7, 65}, {1206, 7, 8, 65}// 1233	1234	1235	
			, {1206, 7, 9, 65}, {1206, 8, 0, 65}, {1206, 8, 1, 65}// 1236	1237	1238	
			, {1206, 8, 2, 65}, {1206, 8, 3, 65}, {1206, 8, 4, 65}// 1239	1240	1241	
			, {1206, 8, 5, 65}, {1206, 8, 6, 65}, {1206, 8, 7, 65}// 1242	1243	1244	
			, {1206, 8, 8, 65}, {1206, 8, 9, 65}, {37, 2, 9, 65}// 1245	1246	1247	
			, {2176, 3, 1, 25}, {1852, 3, 0, 15}, {1852, 2, 1, 10}// 1248	1249	1250	
			, {1852, 2, 0, 10}, {2182, 4, 1, 25}, {2174, 5, 7, 27}// 1251	1252	1253	
			, {2183, 2, 9, 44}, {1850, 3, 8, 35}, {38, 8, 9, 65}// 1254	1255	1256	
			, {2183, 6, 8, 45}, {38, 8, 8, 65}, {1872, 9, 4, 2}// 1257	1258	1259	
			, {1850, 2, 8, 40}, {1238, 2, 6, 45}, {1848, 4, 1, 15}// 1260	1262	1263	
			, {38, 8, 6, 65}, {1998, 2, -5, 5}, {1998, 2, -4, 5}// 1265	1266	1267	
			, {1998, 2, -3, 5}, {1998, 2, -2, 5}, {1998, 3, -5, 5}// 1268	1269	1270	
			, {1998, 3, -4, 5}, {1998, 3, -3, 5}, {1998, 3, -2, 5}// 1271	1272	1273	
			, {1998, 4, -5, 5}, {1998, 4, -4, 5}, {1998, 4, -3, 5}// 1274	1275	1276	
			, {1998, 4, -2, 5}, {1998, 5, -5, 5}, {1998, 5, -4, 5}// 1277	1278	1279	
			, {1998, 5, -3, 5}, {1998, 5, -2, 5}, {1998, 6, -5, 5}// 1280	1281	1282	
			, {1998, 6, -4, 5}, {1998, 6, -3, 5}, {1998, 6, -2, 5}// 1283	1284	1285	
			, {1998, 7, -5, 5}, {1998, 7, -4, 5}, {1998, 7, -3, 5}// 1286	1287	1288	
			, {1998, 7, -2, 5}, {1998, 8, -5, 5}, {1998, 8, -4, 5}// 1289	1290	1291	
			, {1998, 8, -3, 5}, {1998, 8, -2, 5}, {1848, 4, 0, 10}// 1292	1293	1294	
			, {1848, 4, 0, 5}, {1848, 4, 1, 5}, {1848, 4, 0, 15}// 1295	1296	1297	
			, {1848, 4, 1, 10}, {1879, 10, 3, 0}, {2174, 5, 7, 27}// 1298	1299	1300	
			, {2178, 2, 1, 12}, {1848, 3, 8, 25}, {1848, 3, 7, 30}// 1301	1302	1303	
			, {1848, 2, 8, 30}, {2178, 1, 1, 7}// 1304	1305	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new Aiakos_Chateau_Test2AddonDeed();
			}
		}

		[ Constructable ]
		public Aiakos_Chateau_Test2Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 15, -10, -6, 5, 0, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 14, -7, -9, 5, 0, 1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 14, -2, -9, 5, 0, 1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 15, -10, 4, 5, 0, 1, "", 1);// 353
			AddComplexComponent( (BaseAddon) this, 15, -10, -1, 5, 0, 1, "", 1);// 355
			AddComplexComponent( (BaseAddon) this, 10670, 1, 9, 45, 0, 1, "", 1);// 807
			AddComplexComponent( (BaseAddon) this, 10670, 1, 9, 5, 0, 1, "", 1);// 809
			AddComplexComponent( (BaseAddon) this, 10670, 5, 9, 45, 0, 1, "", 1);// 810
			AddComplexComponent( (BaseAddon) this, 10673, 8, 6, 25, 0, 1, "", 1);// 830
			AddComplexComponent( (BaseAddon) this, 10673, 8, 8, 25, 0, 1, "", 1);// 841
			AddComplexComponent( (BaseAddon) this, 10673, 8, 8, 5, 0, 1, "", 1);// 877
			AddComplexComponent( (BaseAddon) this, 10673, 8, 1, 25, 0, 1, "", 1);// 968
			AddComplexComponent( (BaseAddon) this, 3026, 9, 3, 5, 0, -1, "Chateau Magic By Aiakos", 1);// 970
			AddComplexComponent( (BaseAddon) this, 10670, 5, 9, 5, 0, 1, "", 1);// 997
			AddComplexComponent( (BaseAddon) this, 10670, 1, 9, 25, 0, 1, "", 1);// 999
			AddComplexComponent( (BaseAddon) this, 10673, 8, 1, 5, 0, 1, "", 1);// 1010
			AddComplexComponent( (BaseAddon) this, 10673, 8, 1, 45, 0, 1, "", 1);// 1038
			AddComplexComponent( (BaseAddon) this, 10673, 8, 3, 25, 0, 1, "", 1);// 1045
			AddComplexComponent( (BaseAddon) this, 10670, 5, 9, 25, 0, 1, "", 1);// 1070
			AddComplexComponent( (BaseAddon) this, 10673, 8, 8, 45, 0, 1, "", 1);// 1074
			AddComplexComponent( (BaseAddon) this, 10673, 8, 6, 45, 0, 1, "", 1);// 1261
			AddComplexComponent( (BaseAddon) this, 10673, 8, 3, 45, 0, 1, "", 1);// 1264

		}

		public Aiakos_Chateau_Test2Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class Aiakos_Chateau_Test2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new Aiakos_Chateau_Test2Addon();
			}
		}

		[Constructable]
		public Aiakos_Chateau_Test2AddonDeed()
		{
			Name = "Aiakos_Chateau_Test2";
		}

		public Aiakos_Chateau_Test2AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}