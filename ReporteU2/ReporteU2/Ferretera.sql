-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         5.0.27-community-nt - MySQL Community Edition (GPL)
-- SO del servidor:              Win32
-- HeidiSQL Versión:             9.3.0.4984
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
-- Volcando datos para la tabla ferretera.clientes: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`Cli`, `Cliente`, `Domicilio`, `Ciudad`, `Fotografia`, `LimCredito`) VALUES
	(1, 'Pedro López ', 'Altares', 'Hermosillo', NULL, 3600),
	(2, 'Ana Cervantes', 'Nuevo Hermosillo', 'Hermosillo', NULL, 4200),
	(3, 'Luis González ', 'Lomas', 'Hermosillo', NULL, 12000);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando datos para la tabla ferretera.detalles: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `detalles` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalles` ENABLE KEYS */;

-- Volcando datos para la tabla ferretera.facturas: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `facturas` DISABLE KEYS */;
INSERT INTO `facturas` (`Folio`, `Cli`, `Total`, `Fecha`, `Acredito`) VALUES
	(1, 1, 2100, '2020-02-15', 1),
	(2, 2, 3800, '2020-02-16', 1),
	(3, 3, 3200, '2020-02-17', 1),
	(4, 3, 3200, '2020-03-16', 1);
/*!40000 ALTER TABLE `facturas` ENABLE KEYS */;

-- Volcando datos para la tabla ferretera.productos: ~7 rows (aproximadamente)
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` (`Prod`, `Producto`, `Precio`, `Existencia`, `Reorden`) VALUES
	(1, 'Camiseta', 800, 100, 50),
	(2, 'Zapatos', 1050, 200, 50),
	(3, 'Chammarra', 1600, 100, 75),
	(4, 'Tennis', 1000, 50, 40),
	(5, 'Pantalón ', 1200, 10, 5),
	(6, 'sandalias', 200, 50, 10),
	(7, 'Gorra', 100, 200, 50);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
