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
-- Volcando datos para la tabla cobranza.clientes: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`Cli`, `Cliente`, `Domicilio`, `Ciudad`, `LimCredito`) VALUES
	(1, 'Pedro López ', 'Avenida Poder Nacional #30', 'Hermosillo', 3600),
	(2, 'Ana Cervantes', 'Lopez Portillo', 'Hermosillo', 4200),
	(3, 'Luis González ', 'Calle 3', 'Hermosillo', 12000);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Volcando datos para la tabla cobranza.cobradores: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `cobradores` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobradores` ENABLE KEYS */;

-- Volcando datos para la tabla cobranza.pagos: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `pagos` DISABLE KEYS */;
INSERT INTO `pagos` (`Pago`, `Venta`, `Cob`, `FechaPago`, `Importe`) VALUES
	(1, 1, NULL, NULL, 1600),
	(2, 2, NULL, NULL, 3000),
	(3, 3, NULL, NULL, 1000),
	(4, 4, NULL, NULL, 1000);
/*!40000 ALTER TABLE `pagos` ENABLE KEYS */;

-- Volcando datos para la tabla cobranza.ventas: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` (`Venta`, `Cli`, `Folio`, `FechaVenta`, `Total`) VALUES
	(1, 1, 1, '2020-02-15', 2100),
	(2, 2, 2, '2020-02-16', 3800),
	(3, 3, 3, '2020-02-17', 3000),
	(4, 3, 4, '2020-03-16', 3400);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
