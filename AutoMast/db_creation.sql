-- MySQL Script generated by MySQL Workbench
-- Wed Jun 17 11:29:25 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`employees`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`employees` (
  `em_id` INT NOT NULL AUTO_INCREMENT,
  `em_name` VARCHAR(20) NULL,
  `em_surname` VARCHAR(20) NULL,
  `em_patronymic` VARCHAR(20) NULL,
  `em_phone` VARCHAR(15) NULL,
  `em_adress` VARCHAR(50) NULL,
  PRIMARY KEY (`em_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`brigade`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`brigade` (
  `br_id` INT NOT NULL AUTO_INCREMENT,
  `br_head` INT NULL,
  `br_name` VARCHAR(50) NULL,
  PRIMARY KEY (`br_id`),
  INDEX `fk_brigade_employees1_idx` (`br_head` ASC) VISIBLE,
  CONSTRAINT `fk_brigade_employees1`
    FOREIGN KEY (`br_head`)
    REFERENCES `mydb`.`employees` (`em_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`district`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`district` (
  `ds_id` INT NOT NULL AUTO_INCREMENT,
  `ds_brigade` INT NULL,
  `ds_head` INT NULL,
  `ds_name` VARCHAR(50) NULL,
  PRIMARY KEY (`ds_id`),
  INDEX `fk_district_brigade1_idx` (`ds_brigade` ASC) VISIBLE,
  INDEX `fk_district_employees1_idx` (`ds_head` ASC) VISIBLE,
  CONSTRAINT `fk_district_brigade1`
    FOREIGN KEY (`ds_brigade`)
    REFERENCES `mydb`.`brigade` (`br_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_district_employees1`
    FOREIGN KEY (`ds_head`)
    REFERENCES `mydb`.`employees` (`em_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`workshop`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`workshop` (
  `wr_id` INT NOT NULL,
  `wr_district` INT NOT NULL,
  `wr_head` INT NULL,
  `wr_name` VARCHAR(50) NULL,
  PRIMARY KEY (`wr_id`, `wr_district`),
  INDEX `fk_workshop_district1_idx` (`wr_district` ASC) VISIBLE,
  INDEX `fk_workshop_employees1_idx` (`wr_head` ASC) VISIBLE,
  CONSTRAINT `fk_workshop_district1`
    FOREIGN KEY (`wr_district`)
    REFERENCES `mydb`.`district` (`ds_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_workshop_employees1`
    FOREIGN KEY (`wr_head`)
    REFERENCES `mydb`.`employees` (`em_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`product_categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`product_categories` (
  `pc_id` INT NOT NULL AUTO_INCREMENT,
  `pc_name` VARCHAR(50) NULL,
  `pc_description` VARCHAR(250) NULL,
  PRIMARY KEY (`pc_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`manufactured_products`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`manufactured_products` (
  `mp_id` INT NOT NULL AUTO_INCREMENT,
  `mp_product_category` INT NULL,
  `mp_name` VARCHAR(50) NULL,
  `mp_description` VARCHAR(250) NULL,
  PRIMARY KEY (`mp_id`),
  INDEX `fk_manufactured_products_product_categories1_idx` (`mp_product_category` ASC) VISIBLE,
  CONSTRAINT `fk_manufactured_products_product_categories1`
    FOREIGN KEY (`mp_product_category`)
    REFERENCES `mydb`.`product_categories` (`pc_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`staff_categories`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`staff_categories` (
  `sc_id` INT NOT NULL AUTO_INCREMENT,
  `sc_name` VARCHAR(50) NULL,
  `sc_description` VARCHAR(50) NULL,
  `sc_special` TINYINT(1) NULL,
  PRIMARY KEY (`sc_id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`product_records`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`product_records` (
  `pr_id` INT NOT NULL AUTO_INCREMENT,
  `pr_wokshop` INT NULL,
  `pr_product_number` INT NULL,
  `pr_count` INT NULL,
  `pr_date` DATE NULL,
  PRIMARY KEY (`pr_id`),
  INDEX `fk_product_records_workshop1_idx` (`pr_wokshop` ASC) VISIBLE,
  INDEX `fk_product_records_manufactured_products1_idx` (`pr_product_number` ASC) VISIBLE,
  CONSTRAINT `fk_product_records_workshop1`
    FOREIGN KEY (`pr_wokshop`)
    REFERENCES `mydb`.`workshop` (`wr_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_product_records_manufactured_products1`
    FOREIGN KEY (`pr_product_number`)
    REFERENCES `mydb`.`manufactured_products` (`mp_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`empoloyees_characteristic`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`empoloyees_characteristic` (
  `ec_id` INT NOT NULL,
  `ec_staff_category` INT NULL,
  `ec_brigade` INT NULL,
  PRIMARY KEY (`ec_id`),
  INDEX `fk_empoloyees_characteristic_staff_categories_idx` (`ec_staff_category` ASC) VISIBLE,
  INDEX `fk_empoloyees_characteristic_employees1_idx` (`ec_id` ASC) VISIBLE,
  INDEX `fk_empoloyees_characteristic_brigade1_idx` (`ec_brigade` ASC) VISIBLE,
  CONSTRAINT `fk_empoloyees_characteristic_staff_categories`
    FOREIGN KEY (`ec_staff_category`)
    REFERENCES `mydb`.`staff_categories` (`sc_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_empoloyees_characteristic_employees1`
    FOREIGN KEY (`ec_id`)
    REFERENCES `mydb`.`employees` (`em_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_empoloyees_characteristic_brigade1`
    FOREIGN KEY (`ec_brigade`)
    REFERENCES `mydb`.`brigade` (`br_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `mydb`.`employees`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`employees` (`em_id`, `em_name`, `em_surname`, `em_patronymic`, `em_phone`, `em_adress`) VALUES (1, '????????', '???????????? ', '????????????????', '+375291234567', 'address1@mail.com');
INSERT INTO `mydb`.`employees` (`em_id`, `em_name`, `em_surname`, `em_patronymic`, `em_phone`, `em_adress`) VALUES (2, '????????', '????????????', '????????????????', '+375297654321', 'address2@mail.com');
INSERT INTO `mydb`.`employees` (`em_id`, `em_name`, `em_surname`, `em_patronymic`, `em_phone`, `em_adress`) VALUES (3, '????????', '??????????????', '??????????????????', '+375441234567', 'address3@mail.com');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`brigade`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`brigade` (`br_id`, `br_head`, `br_name`) VALUES (1, 1, '???????????????????????????? ');
INSERT INTO `mydb`.`brigade` (`br_id`, `br_head`, `br_name`) VALUES (2, 3, '????????????');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`district`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`district` (`ds_id`, `ds_brigade`, `ds_head`, `ds_name`) VALUES (1, 1, 1, '?????????? ????????????????????????????');
INSERT INTO `mydb`.`district` (`ds_id`, `ds_brigade`, `ds_head`, `ds_name`) VALUES (2, 2, 3, '?????????? ????????????');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`workshop`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`workshop` (`wr_id`, `wr_district`, `wr_head`, `wr_name`) VALUES (1, 1, 1, '?????????????? ??????');
INSERT INTO `mydb`.`workshop` (`wr_id`, `wr_district`, `wr_head`, `wr_name`) VALUES (1, 2, 1, '?????????????? ??????');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`product_categories`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`product_categories` (`pc_id`, `pc_name`, `pc_description`) VALUES (1, '???????????????? ????????????????????', '???????????????????????? ???????????????? ??????????????????????');
INSERT INTO `mydb`.`product_categories` (`pc_id`, `pc_name`, `pc_description`) VALUES (2, '???????????????? ????????????????????', '???????????????????????? ???????????????? ??????????????????????');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`manufactured_products`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`manufactured_products` (`mp_id`, `mp_product_category`, `mp_name`, `mp_description`) VALUES (1, 1, '?????? 1', '???????????????? ???????????????????? ?????????? ??????');
INSERT INTO `mydb`.`manufactured_products` (`mp_id`, `mp_product_category`, `mp_name`, `mp_description`) VALUES (2, 1, '?????? 2', '???????????????? ???????????????????? ?????????? ??????');
INSERT INTO `mydb`.`manufactured_products` (`mp_id`, `mp_product_category`, `mp_name`, `mp_description`) VALUES (3, 2, '???? 1', '???????????????? ?????????????????? ???????? ????');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`staff_categories`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`staff_categories` (`sc_id`, `sc_name`, `sc_description`, `sc_special`) VALUES (1, '??????????????', '???????????????????? ??????????????????????????????', 1);
INSERT INTO `mydb`.`staff_categories` (`sc_id`, `sc_name`, `sc_description`, `sc_special`) VALUES (2, '????????????', '???????????????????? ??????????????????????????', 1);
INSERT INTO `mydb`.`staff_categories` (`sc_id`, `sc_name`, `sc_description`, `sc_special`) VALUES (3, '???????????????? ', '???????????????????? ????????????', 1);
INSERT INTO `mydb`.`staff_categories` (`sc_id`, `sc_name`, `sc_description`, `sc_special`) VALUES (4, '??????????????', '???????????????????? ??????????????', 0);
INSERT INTO `mydb`.`staff_categories` (`sc_id`, `sc_name`, `sc_description`, `sc_special`) VALUES (5, '??????????????', '???????????????????? ??????????????', 0);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`product_records`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`product_records` (`pr_id`, `pr_wokshop`, `pr_product_number`, `pr_count`, `pr_date`) VALUES (1, 1, 1, 5, '2020-01-01');
INSERT INTO `mydb`.`product_records` (`pr_id`, `pr_wokshop`, `pr_product_number`, `pr_count`, `pr_date`) VALUES (2, 1, 2, 10, '2020-02-01');
INSERT INTO `mydb`.`product_records` (`pr_id`, `pr_wokshop`, `pr_product_number`, `pr_count`, `pr_date`) VALUES (3, 1, 3, 2, '2020-02-10');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`empoloyees_characteristic`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`empoloyees_characteristic` (`ec_id`, `ec_staff_category`, `ec_brigade`) VALUES (1, 1, 1);
INSERT INTO `mydb`.`empoloyees_characteristic` (`ec_id`, `ec_staff_category`, `ec_brigade`) VALUES (2, 1, 1);
INSERT INTO `mydb`.`empoloyees_characteristic` (`ec_id`, `ec_staff_category`, `ec_brigade`) VALUES (3, 4, 2);

COMMIT;

