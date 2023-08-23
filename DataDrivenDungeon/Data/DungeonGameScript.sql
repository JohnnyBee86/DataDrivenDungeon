USE [DungeonGame]
GO
SET IDENTITY_INSERT [dbo].[Armors] ON 
GO
INSERT [dbo].[Armors] ([ArmorId], [ArmorName], [ArmorCost], [ArmorHealthMax]) 
	VALUES (1, N'T-Shirt', 0, 25)
GO
INSERT [dbo].[Armors] ([ArmorId], [ArmorName], [ArmorCost], [ArmorHealthMax]) 
	VALUES (2, N'Leather', 10, 35)
GO
INSERT [dbo].[Armors] ([ArmorId], [ArmorName], [ArmorCost], [ArmorHealthMax]) 
	VALUES (3, N'Chain-mail', 20, 45)
GO
INSERT [dbo].[Armors] ([ArmorId], [ArmorName], [ArmorCost], [ArmorHealthMax]) 
	VALUES (4, N'Plate', 30, 60)
GO
SET IDENTITY_INSERT [dbo].[Armors] OFF
GO

SET IDENTITY_INSERT [dbo].[Weapons] ON 
GO
INSERT [dbo].[Weapons] ([WeaponId], [WeaponName], [WeaponCost],
	[DamageMin], [DamageMax]) 
	VALUES (1, N'Dagger', 0, 1, 2)
GO
INSERT [dbo].[Weapons] ([WeaponId], [WeaponName], [WeaponCost],
	[DamageMin], [DamageMax]) 
	VALUES (2, N'Shortsword', 10, 2, 4)
GO
INSERT [dbo].[Weapons] ([WeaponId], [WeaponName], [WeaponCost],
	[DamageMin], [DamageMax]) 
	VALUES (3, N'Longsword', 20, 4, 6)
GO
INSERT [dbo].[Weapons] ([WeaponId], [WeaponName], [WeaponCost],
	[DamageMin], [DamageMax]) 
	VALUES (4, N'Greatsword', 30, 6, 9)
GO
SET IDENTITY_INSERT [dbo].[Weapons] OFF
GO

SET IDENTITY_INSERT [dbo].[Dungeons] ON 
GO
INSERT [dbo].[Dungeons] ([DungeonId], [DungeonName], [FightsBeforeBoss], 
	[EnemyMinPerFight], [ExtraEnemyChance]) 
	VALUES (1, N'Cave', 6, 1, 0)
GO
INSERT [dbo].[Dungeons] ([DungeonId], [DungeonName], [FightsBeforeBoss],
	[EnemyMinPerFight], [ExtraEnemyChance]) 
	VALUES (2, N'Goblin Camp', 8, 1, 40)
GO
INSERT [dbo].[Dungeons] ([DungeonId], [DungeonName], [FightsBeforeBoss],
	[EnemyMinPerFight], [ExtraEnemyChance]) 
	VALUES (3, N'Orc War Band', 10, 2, 30)
GO
SET IDENTITY_INSERT [dbo].[Dungeons] OFF
GO

SET IDENTITY_INSERT [dbo].[Creatures] ON
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (1, 1, 'Slime', 0, 2, 3, 0, 1, 0, 1, null, 0)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (2, 1, 'Spider', 0, 4, 5, 1, 2, 1, 3, null, 0)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (3, 1, 'Big Spider', 1, 10, 15, 2, 5, 10, 10, null, 0)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (4, 2, 'Goblin', 0, 4, 5, 1, 2, 1, 3, 'Emblem', 30)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (5, 2, 'Goblin Captain', 0, 5, 8, 2, 4, 3, 6, 'Emblem', 40)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (6, 2, 'Goblin Lord', 1, 15, 20, 3, 5, 10, 20, 'Emblem', 100)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (7, 3, 'Orc', 0, 5, 7, 2, 4, 3, 6, 'Emblem', 30)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (8, 3, 'Orc Archer', 0, 5, 7, 1, 4, 1, 3, 'Emblem', 30)
GO
INSERT [dbo].[Creatures] ([CreatureId], [FightInDungeonDungeonId]
	, [CreatureName], [IsBoss], [HealthMin], [HealthMax], [DamageMin]
	, [DamageMax], [CoinDropMin], [CoinDropMax], [BonusDrop], [BonusDropChance])
	VALUES (9, 3, 'Orc Warmaster', 1, 25, 35, 4, 6, 200, 200, 'Emblem', 100)
GO
SET IDENTITY_INSERT [dbo].[Creatures] ON
GO