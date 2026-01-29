

CREATE TABLE `creditos`.`cliente` (
  `idCliente` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `ApellidoPaterno` VARCHAR(45) NULL,
  `ApellidoMaterno` VARCHAR(45) NULL,
  `TipoDocumento` CHAR(3) NOT NULL,
  `NumeroDocumento` VARCHAR(11) NOT NULL,
  `Sexo` CHAR(1) NOT NULL,
  `FechaNac` DATETIME NOT NULL,
  `Direccion` VARCHAR(200) NOT NULL,
  `CodigoPostal` VARCHAR(50) NOT NULL,
  `EstadoCivil` CHAR(1) NOT NULL,
  PRIMARY KEY (`idCliente`));


// Stored Procedure: sp_obtener_cliente_por_documento

USE `creditos`;
DROP procedure IF EXISTS `sp_obtener_cliente_por_documento`;

DELIMITER $$
USE `creditos`$$
CREATE PROCEDURE `sp_obtener_cliente_por_documento` (IN p_numero_documento VARCHAR(20))
BEGIN
 SELECT *
    FROM cliente
    WHERE NumeroDocumento = p_numero_documento;
END$$

DELIMITER ;



// Stored Procedure: sp_obtener_clientes

USE `creditos`;
DROP procedure IF EXISTS `sp_obtener_clientes`;

DELIMITER $$
USE `creditos`$$
CREATE PROCEDURE `sp_obtener_clientes`()
BEGIN
 SELECT *
    FROM cliente;
END$$

DELIMITER ;

// Insertar datos de ejemplo

INSERT INTO `creditos`.`cliente`
(`idCliente`,
`Nombre`,
`ApellidoPaterno`,
`ApellidoMaterno`,
`TipoDocumento`,
`NumeroDocumento`,
`Sexo`,
`FechaNac`,
`Direccion`,
`CodigoPostal`,
`EstadoCivil`)
VALUES
(1,
'Yoan Steiner',
'Huaca',
'Valdes',
'CC',
1117539824,
'M',
'1995-05-26',
'CALLE FALSA #123',
'18001',
'U');


INSERT INTO `creditos`.`cliente`
(`idCliente`,
`Nombre`,
`ApellidoPaterno`,
`ApellidoMaterno`,
`TipoDocumento`,
`NumeroDocumento`,
`Sexo`,
`FechaNac`,
`Direccion`,
`CodigoPostal`,
`EstadoCivil`)
VALUES
(3,
'Pedro Pablo',
'Yague',
'Cometa',
'CC',
11185224587,
'M',
'1995-05-28',
'CALLE FALSA #123',
'18001',
'U');