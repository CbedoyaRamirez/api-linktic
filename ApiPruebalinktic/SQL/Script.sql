CREATE TABLE `app-linktic`.reservation (
  `id` int NOT NULL AUTO_INCREMENT,
  `idCliente` int DEFAULT NULL,
  `dateReservation` datetime DEFAULT NULL,
  `status` int DEFAULT NULL,
  `obervations` varchar(200) DEFAULT NULL,
  `numPerson` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
