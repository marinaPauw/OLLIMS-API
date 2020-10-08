CREATE TABLE [laboratories] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [laboratoryName] nvarchar(255),
  [description] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [instruments] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [laboratoryId] integer,
  [measurementId] integer,
  [SOPId] integer,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [measurements] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [instrumentId] integer,
  [name] nvarchar(255),
  [lowerLimit] double,
  [upperLimit] double,
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [measurementValues] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [measurementId] integer,
  [value] double,
  [MeasuredDatetime] datetime,
  [LoggedDateTime] datetime
)
GO

CREATE TABLE [SOP] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [name] nvarchar(255),
  [version] nvarchar(255),
  [instructionURL] nvarchar(255),
  [documentURL] nvarchar(255),
  [createdAt] datetime,
  [updatedAt] datetime
)
GO

CREATE TABLE [SOP_trainees] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [SOPId] integer,
  [personId] integer,
  [certificateURL] nvarchar(255),
  [trainedAt] datetime
)
GO

CREATE TABLE [personel] (
  [id] integer PRIMARY KEY IDENTITY(1, 1),
  [firstname] nvarchar(255),
  [lastname] nvarchar(255),
  [position] nvarchar(255),
  [accessLevelId] integer
)
GO

CREATE TABLE [accessLevels] (
  [id] integer,
  [name] nvarchar(255)
)
GO
ALTER TABLE [instruments] ADD FOREIGN KEY ([laboratoryId]) REFERENCES [laboratories] ([id])
GO
ALTER TABLE [instruments] ADD FOREIGN KEY ([measurementId]) REFERENCES [measurements] ([id])
GO


ALTER TABLE [measurementValues] ADD FOREIGN KEY ([measurementId])REFERENCES [measurements] ([id]) 
GO

ALTER TABLE [instruments] ADD FOREIGN KEY ([SOPId]) REFERENCES [SOP] ([id])
GO

ALTER TABLE [SOP_trainees] ADD FOREIGN KEY ([SOPId]) REFERENCES [SOP] ([id])
GO

ALTER TABLE [SOP_trainees] ADD FOREIGN KEY ([personId]) REFERENCES [personel] ([id])
GO


ALTER TABLE [personel] ADD FOREIGN KEY ([accessLevelId]) REFERENCES [accessLevels] ([id])
GO
