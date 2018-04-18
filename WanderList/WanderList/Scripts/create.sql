/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES'; */

-- -----------------------------------------------------
-- Schema Wanderlist
-- -----------------------------------------------------
-- CREATE SCHEMA IF NOT EXISTS Wanderlist DEFAULT CHARACTER SET utf8;
--IF (SCHEMA_ID('Wanderlist') IS NULL) 
--BEGIN
--    EXEC ('CREATE SCHEMA [Wanderlist] AUTHORIZATION [dbo]')
--END

USE Wanderlist ;

-- -----------------------------------------------------
-- Table `Wanderlist`.`Location`
-- -----------------------------------------------------
CREATE TABLE [Wanderlist.Location] (
  [location_id] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  [address] VARCHAR(45) NOT NULL,
  [rating] DECIMAL(4,2) NOT NULL,
  [description] VARCHAR(125) NOT NULL,
  PRIMARY KEY ([location_id]),
  CONSTRAINT [location_id_UNIQUE] UNIQUE ([location_id] ASC))
;


-- -----------------------------------------------------
-- Table `Wanderlist`.`User`
-- -----------------------------------------------------
CREATE TABLE [Wanderlist.User] (
  [user_id] INT NOT NULL,
  [username] VARCHAR(45) NOT NULL,
  [password] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([user_id]),
  CONSTRAINT [user_id_UNIQUE] UNIQUE  ([user_id] ASC))
;


-- -----------------------------------------------------
-- Table `Wanderlist`.`Saved_Location`
-- -----------------------------------------------------
CREATE TABLE [Wanderlist.Saved_Location] (
  [saved_location_id] INT NOT NULL,
  [user_id] INT NOT NULL,
  [location_id] INT NOT NULL,
  PRIMARY KEY ([saved_location_id])
 ,
  CONSTRAINT [saved_location_id_UNIQUE] UNIQUE  ([saved_location_id] ASC),
  CONSTRAINT [fk_user_id]
    FOREIGN KEY ([user_id])
    REFERENCES [Wanderlist.User] ([user_id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_location_id]
    FOREIGN KEY ([location_id])
    REFERENCES [Wanderlist.Location] ([location_id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_user_id_idx] ON [Wanderlist.Saved_Location] ([user_id] ASC);
CREATE INDEX [fk_location_id_idx] ON [Wanderlist.Saved_Location] ([location_id] ASC);


-- -----------------------------------------------------
-- Table `Wanderlist`.`Viewed_Location`
-- -----------------------------------------------------
CREATE TABLE [Wanderlist.Viewed_Location] (
  [viewed_location_id] INT NOT NULL,
  [user_id] INT NOT NULL,
  [location_id] INT NOT NULL,
  PRIMARY KEY ([viewed_location_id]),
  CONSTRAINT [viewed_location_id_UNIQUE] UNIQUE  ([viewed_location_id] ASC)
 ,
  CONSTRAINT [fk_user_id]
    FOREIGN KEY ([user_id])
    REFERENCES [Wanderlist.User] ([user_id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_location_id]
    FOREIGN KEY ([location_id])
    REFERENCES [Wanderlist.Location] ([location_id])
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
;

CREATE INDEX [fk_user_id_idx] ON [Wanderlist.Viewed_Location] ([user_id] ASC);
CREATE INDEX [fk_location_id_idx] ON [Wanderlist.Viewed_Location] ([location_id] ASC);


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
