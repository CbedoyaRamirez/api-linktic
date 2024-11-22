# APP prueba Linktic

Prueba generadad en .Net Core 8.0

## Instalaciòn

Realizar los siguientes paso: 

1) Realizar git clone del proyecto 
```bash
git clone https://github.com/CbedoyaRamirez/api-linktic.git
```

2) Ejecutar el proyecto

## Base de datos

El proyecto fue realizado con base de datos MySQL

Ejecutar los siguiente comando para crear tanto la instacia como la tabla de reservas

```bash

CREATE DATABASE `app-linktic` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

CREATE TABLE `app-linktic`.reservation (
  `id` int NOT NULL AUTO_INCREMENT,
  `idCliente` int DEFAULT NULL,
  `dateReservation` datetime DEFAULT NULL,
  `status` int DEFAULT NULL,
  `obervations` varchar(200) DEFAULT NULL,
  `numPerson` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```



