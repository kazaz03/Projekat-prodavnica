/*
Navicat MySQL Data Transfer

Source Server         : kazaz
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projekat_baza

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-06 21:13:49
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
`artikal_id`  int(11) NOT NULL AUTO_INCREMENT ,
`naziv_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`vrsta_artikla`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`cijena`  double NULL DEFAULT NULL ,
PRIMARY KEY (`artikal_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=18 */

;

-- ----------------------------
-- Records of artikal
-- ----------------------------
BEGIN;
INSERT INTO `artikal` VALUES ('1', 'ABC sir', 'Prehrambeni', '3'), ('14', 'Huawei P7', 'Mobitel', '490'), ('15', 'Xiaomi Airdots', 'Slušalice', '60'), ('16', 'PS5', 'Konzola', '1600'), ('17', 'GeForce RTX 3090', 'Graficka kartica', '3000');
COMMIT;

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
`kupac_id`  int(11) NOT NULL AUTO_INCREMENT ,
`ime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`prezime`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`grad`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`adresa`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`telefon`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`user`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
`pass`  varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NULL DEFAULT NULL ,
PRIMARY KEY (`kupac_id`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
/*!50003 AUTO_INCREMENT=6 */

;

-- ----------------------------
-- Records of kupac
-- ----------------------------
BEGIN;
INSERT INTO `kupac` VALUES ('1', 'Admin', 'Ministrator', 'Sarajevo', 'Sarajevska 1', '0611111', 'Admin', '1234'), ('2', 'Amina', 'Kazazovic', 'Sarajevo', 'Doljani 52', '062241331', 'Kazaz', '5678'), ('3', 'Rasim', 'Rasimović', 'Banja  Luka', 'Banjalučka 17', '063666666', 'Rasko', '4321'), ('4', 'Benjamin', 'Baždar', 'Vogošca', 'Jošanicka 45', '062451562', 'Dzombi', '2003'), ('5', 'Sabaheta', 'Sahic', 'Mostar', 'Mostarska 56', '0608929182', 'Sabka', '2000');
COMMIT;

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
`narudzbenica_id`  int(11) NOT NULL AUTO_INCREMENT ,
`kupac_id`  int(11) NULL DEFAULT NULL ,
`datum_narudzbe`  date NULL DEFAULT NULL ,
PRIMARY KEY (`narudzbenica_id`),
FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`kupac_id`) REFER `projekat/kupac`(`k'
/*!50003 AUTO_INCREMENT=23 */

;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
BEGIN;
INSERT INTO `narudzbenica` VALUES ('17', '2', '2022-04-06'), ('18', '3', '2022-04-06'), ('20', '5', '2022-04-06'), ('21', '4', '2022-04-06'), ('22', '3', '2022-04-06');
COMMIT;

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
`id`  int(11) NOT NULL AUTO_INCREMENT ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina_stanje`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal'
/*!50003 AUTO_INCREMENT=9 */

;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
BEGIN;
INSERT INTO `skladiste` VALUES ('1', '1', '0'), ('5', '14', '8'), ('6', '15', '10'), ('7', '16', '17'), ('8', '17', '15');
COMMIT;

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
`stavka_id`  int(11) NOT NULL AUTO_INCREMENT ,
`narudzbenica_id`  int(11) NULL DEFAULT NULL ,
`artikal_id`  int(11) NULL DEFAULT NULL ,
`kolicina`  int(11) NULL DEFAULT NULL ,
PRIMARY KEY (`stavka_id`),
FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`) ON DELETE RESTRICT ON UPDATE RESTRICT
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=utf8 COLLATE=utf8_unicode_ci
COMMENT='InnoDB free: 3072 kB; (`artikal_id`) REFER `projekat/artikal'
/*!50003 AUTO_INCREMENT=45 */

;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
BEGIN;
INSERT INTO `stavka_narudzbenice` VALUES ('5', '17', '1', '12'), ('37', '18', '14', '2'), ('38', '20', '17', '5'), ('39', '20', '1', '1'), ('40', '21', '16', '3'), ('41', '21', '1', '3'), ('42', '17', '17', '1'), ('43', '18', '1', '1'), ('44', '22', '1', '5');
COMMIT;

-- ----------------------------
-- Auto increment value for `artikal`
-- ----------------------------
ALTER TABLE `artikal` AUTO_INCREMENT=18;

-- ----------------------------
-- Auto increment value for `kupac`
-- ----------------------------
ALTER TABLE `kupac` AUTO_INCREMENT=6;

-- ----------------------------
-- Indexes structure for table `narudzbenica`
-- ----------------------------
CREATE INDEX `narudzbenica_kupac_id` USING BTREE ON `narudzbenica`(`kupac_id`);

-- ----------------------------
-- Auto increment value for `narudzbenica`
-- ----------------------------
ALTER TABLE `narudzbenica` AUTO_INCREMENT=23;

-- ----------------------------
-- Indexes structure for table `skladiste`
-- ----------------------------
CREATE INDEX `skladiste_artikal_id` USING BTREE ON `skladiste`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `skladiste`
-- ----------------------------
ALTER TABLE `skladiste` AUTO_INCREMENT=9;

-- ----------------------------
-- Indexes structure for table `stavka_narudzbenice`
-- ----------------------------
CREATE INDEX `stavka_narudzbenice_narudzbenica_id` USING BTREE ON `stavka_narudzbenice`(`narudzbenica_id`);
CREATE INDEX `stavka_narudzbenice_artikal_id` USING BTREE ON `stavka_narudzbenice`(`artikal_id`);

-- ----------------------------
-- Auto increment value for `stavka_narudzbenice`
-- ----------------------------
ALTER TABLE `stavka_narudzbenice` AUTO_INCREMENT=45;
