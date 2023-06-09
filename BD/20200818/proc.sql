USE [Sis_optica]
GO
/****** Object:  StoredProcedure [dbo].[actualizacionStock]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizacionStock](
@id int,
@pro_stock int
)as begin
	update productos set pro_stock=@pro_stock
	where id=@id
end




GO
/****** Object:  StoredProcedure [dbo].[actualizacionStockyPrecio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizacionStockyPrecio](
@id int,
@pro_stock int,
@pro_precio decimal(10,2)
)as begin
	update productos set pro_stock=@pro_stock, pro_precio=@pro_precio
	where id=@id
end




GO
/****** Object:  StoredProcedure [dbo].[actualizar_credito_detalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_credito_detalle](
@cdd_id int,
@cdd_fecha_pago smalldatetime,
@tipo_pago varchar(10),
@cdd_abono decimal(10,2),
@cdd_saldo decimal(10,2),
@ccd_mora decimal(10,2),
@cdd_estado int,
@id_caja int
)as begin
	update credito_detalle 
	set		cdd_fecha_pago=@cdd_fecha_pago,
			tipo_pago=@tipo_pago,
			cdd_abono=@cdd_abono,
			cdd_saldo=@cdd_saldo,
			cdd_mora = @ccd_mora,
			cdd_estado=@cdd_estado,
			id_caja=@id_caja
	where cdd_id=@cdd_id

	update credito set cr_moratotal = cr_moratotal + @ccd_mora where id = (select top 1 id_cr_pccorrelativo from credito_detalle where cdd_id = @cdd_id)

end

GO
/****** Object:  StoredProcedure [dbo].[actualizar_inicio_sesion]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_inicio_sesion](
@is_id char(5),
@inicio_caja decimal(10,2),
@caja_ventas decimal(10,2),
@caja_gastos decimal(10,2),
@caja_final decimal(10,2),
@caja_sobrantes decimal(10,2),
@caja_faltantes decimal(10,2)
)as begin		
	 update inicio_sesion set inicio_caja=@inicio_caja,caja_ventas=@caja_ventas,
	 caja_gastos=@caja_gastos,caja_final=@caja_final,caja_sobrantes=@caja_sobrantes, caja_faltantes=@caja_faltantes
	 where is_id=@is_id
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_venta_anulacion]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_venta_anulacion](
@ven_id int
)as begin
	update venta set cli_id='CLI0000000', ven_total=0
	where ven_id=@ven_id
end






GO
/****** Object:  StoredProcedure [dbo].[actualizarclientes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizarclientes](
@cli_id varchar(10),
@cli_numero varchar(15),
@cli_razon varchar(100),
@cli_ocupacion varchar(50),
@cli_sexo varchar(5),
@cli_direccion varchar(100),
@cli_telefono varchar(9),

@nombre varchar(250),
@direccion varchar(250),
@telefono varchar(250),
@garantia varchar(250)
)as begin
	update clientes set cli_numero=@cli_numero,
						cli_razon=@cli_razon,
						cli_ocupacion=@cli_ocupacion,
						cli_sexo=@cli_sexo,
						cli_direccion=@cli_direccion,
						cli_telefono=@cli_telefono, 
						
						nombre = @nombre,
						direccion = @direccion,
						telefono = @telefono,
						garantia = @garantia
	where cli_id=@cli_id
end






GO
/****** Object:  StoredProcedure [dbo].[actualizarconsultorio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizarconsultorio](
@c_id int,
@cli_id char(10),
@uso_lentes2 varchar(50),
@años2 varchar(50),
@od2 varchar(50),
@oi2 varchar(50),
@addd2 varchar(50),
@dip2 varchar(50),
@recomend2 varchar(250),
@c_fecha date,
@od_esf varchar(5),
@od_cil varchar(5),
@od_eje varchar(5),
@od_dip varchar(5),
@id_esf varchar(5),
@id_cil varchar(5),
@id_eje varchar(5),
@id_dip varchar(5),
@addd varchar(20),
@pio_od5 varchar(50),
@pio_oi5 varchar(50),
@pio_od10 varchar(50),
@pio_oi10 varchar(50),
@quera_od1 varchar(50),
@quera_od2 varchar(50),
@quera_oi1 varchar(50),
@quera_oi2 varchar(50),
@recomendaciones varchar(250),
@esp_id char(5)
)as begin
	update consultorio set cli_id=@cli_id,uso_lentes2=@uso_lentes2,años2=@años2,od2=@od2,oi2=@oi2,addd2=@addd2,dip2=@dip2,recomend2=@recomend2,
	c_fecha=@c_fecha,od_esf=@od_esf,od_cil=@od_cil,od_eje=@od_eje,od_dip=@od_dip,id_esf=@id_esf,id_cil=@id_cil,id_eje=@id_eje,id_dip=@id_dip,addd=@addd,
	pio_od5=@pio_od5,pio_oi5=@pio_oi5,pio_od10=@pio_od10,pio_oi10=@pio_oi10,quera_od1=@quera_od1,quera_od2=@quera_od2,quera_oi1=@quera_oi1,quera_oi2=@quera_oi2
	,recomendaciones=@recomendaciones,esp_id=@esp_id
	where c_id=@c_id
end






GO
/****** Object:  StoredProcedure [dbo].[actualizarespecialista]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizarespecialista](
@esp_id char(5) ,
@esp_nombre varchar(100)
)as begin
	update especialista set esp_nombre=@esp_nombre
	where esp_id=@esp_id
end










GO
/****** Object:  StoredProcedure [dbo].[actualizarproductos]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizarproductos](
@id int,
@pro_id varchar(40),
@pro_descripcion varchar(210),
@pro_precio decimal(10,2),
@id_familia int,
@id_linea int
)as begin
	update productos set pro_id=@pro_id ,pro_descripcion=@pro_descripcion,
	pro_precio=@pro_precio,id_familia=@id_familia, id_linea=@id_linea
	where id=@id
end




GO
/****** Object:  StoredProcedure [dbo].[actualizarproveedores]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizarproveedores](
@prov_id char(10),
@prov_ruc varchar(15),
@prov_razon varchar(100),
@prov_direccion varchar(100),
@prov_telefono varchar(9)
)as begin
	update proveedores set prov_ruc=@prov_ruc,prov_razon=@prov_razon,prov_direccion=@prov_direccion,prov_telefono=@prov_telefono
	where prov_id=@prov_id
end






GO
/****** Object:  StoredProcedure [dbo].[actualizarusuario]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizarusuario](
@usu_id char(5),
@usu_dni varchar(8),
@usu_nombre varchar(100),
@usu_direccion varchar(100),
@usu_telefono varchar(9),
@usu_usuario varchar(20),
@usu_clave varchar(20),
@tipo_id int
)as begin
	update usuarios set usu_dni=@usu_dni,usu_nombre=@usu_nombre,usu_direccion=@usu_direccion,usu_telefono=@usu_telefono,usu_usuario=@usu_usuario,usu_clave=@usu_clave,tipo_id=@tipo_id
	where usu_id=@usu_id
end







GO
/****** Object:  StoredProcedure [dbo].[buscar_nota]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[buscar_nota](
@var varchar(10)
)as begin
	select nc_id as ID, nc_serie as SERIE, nc_numero as NUMERO, v2_fechaHora as FECHA, v6_numero_doc as DOCUMENT
	,v7_razon_soci as NOMBRE, v10_motivo_sustento as MOTIVO, v12_serie_numero as 'DOC REFERENCIA', v19_importe_total as TOTAL
	 from Nota_credito
	 where nc_serie like '%' + @var + '%' or v6_numero_doc like '%' + @var + '%' or v7_razon_soci like '%' + @var + '%'
end







GO
/****** Object:  StoredProcedure [dbo].[buscar_nota_salida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_nota_salida](
	@var varchar(20)
)as begin
	select ns_id as ID,ns_numero as CORRELATIVO, ns_fecha as FECHA, u.usu_nombre as USUARIO, motivo as MOTIVO,
		autorizado as 'AUTOIZADO POR', total as TOTAL
	from Nota_Salida
	inner join usuarios as u on u.usu_id=Nota_Salida.usu_id
	where ns_numero like '%' + @var + '%' or usu_nombre like '%' + @var + '%' or motivo like '%' + @var + '%'
	order by ns_numero desc
end





GO
/****** Object:  StoredProcedure [dbo].[buscarcliente]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarcliente](
@cli_razon varchar(20)
)as begin
	select cli_id as ID, cli_numero as NUMERO, cli_razon as 'NOMBRES Y APELLIDOS',cli_ocupacion as OCUPACION
	,cli_sexo as SEXO, 
	cli_direccion as DIRECCION, cli_telefono as TELEFONO, nombre GARANTE, direccion DIRECCIONG, telefono TELEFONOG, garantia GARANTIA
	from clientes
	where cli_razon like '%' + @cli_razon + '%' or cli_numero like '%' + @cli_razon + '%'
end





GO
/****** Object:  StoredProcedure [dbo].[buscarconsultorioXcliente]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarconsultorioXcliente](
@cli varchar(10)
)
as begin
	select c.c_id AS ID,c.c_fecha AS FECHA,es.esp_nombre AS ESPECIALISTA from consultorio as c
	inner join clientes as cl on cl.cli_id=c.cli_id
	inner join especialista as es on es.esp_id=c.esp_id
	where c.cli_id= @cli
end






GO
/****** Object:  StoredProcedure [dbo].[buscarcredito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[buscarcredito](
@cliente varchar(25)
)
as begin
	select c.id ID,c.cr_pccorrelativo as ORDEN,c.cr_fecha as FECHA,u.usu_nombre as PRESTAMISTA,cl.cli_razon as CLIENTES,
	c.cr_monto MONTO,
	c.cr_interes INTERES, 
	c.cr_moratotal MORA,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE, cl.cli_telefono TELEFONO
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id

	inner join credito_detalle cd on cd.id_cr_pccorrelativo = c.id
	where 
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) > 0
	AND  cl.cli_razon like '%' + @cliente + '%' and bestado = 1

	group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia, cl.cli_telefono
	order by cr_pccorrelativo desc	
end

GO
/****** Object:  StoredProcedure [dbo].[buscarproducto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarproducto](
@pro_descripcion varchar(100),
@tbuscar int,
@cod_vende varchar(10),
@familia int,
@linea int,
@Venta int = 0
)as begin
	if	@Venta = 0
	begin
		if @tbuscar=1  -- buscar por descripcion
 			select id as ID, pro_id as CODIGO, pro_descripcion as DECRIPCION,
			pro_stock as STOCK, pro_precio as PRECIO from productos
			where pro_descripcion like '%' + @pro_descripcion + '%' and elim=1 and cod_vende = @cod_vende 
				and id_familia = @familia and id_linea = @linea
		else
			select id as ID, pro_id as CODIGO, pro_descripcion as DECRIPCION,
			pro_stock as STOCK, pro_precio as PRECIO from productos
			where pro_id like '%' + @pro_descripcion + '%' and elim=1 and cod_vende = @cod_vende 
				and id_familia = @familia and id_linea = @linea
	end
	else
	begin
		if @tbuscar=1  -- buscar por descripcion
 			select id as ID, pro_id as CODIGO, pro_descripcion as DECRIPCION,
			pro_stock as STOCK, pro_precio as PRECIO from productos
			where pro_descripcion like '%' + @pro_descripcion + '%' and elim=1 and cod_vende = @cod_vende 
				--and id_familia = @familia and id_linea = @linea
		else
			select id as ID, pro_id as CODIGO, pro_descripcion as DECRIPCION,
			pro_stock as STOCK, pro_precio as PRECIO from productos
			where pro_id like '%' + @pro_descripcion + '%' and elim=1 and cod_vende = @cod_vende 
				--and id_familia = @familia and id_linea = @linea
	end
end


GO
/****** Object:  StoredProcedure [dbo].[buscarventa]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscarventa]
(@cli_razon varchar(20))
as begin
select top (100) v.ven_id as ID,td.td_descripcion as DOC,v.ven_serie as SERIE,v.ven_correlativo as CORRELATIVO,v.ven_fecha as FECHA,
	u.usu_nombre as VENDEDOR,c.cli_razon as CLIENTE,v.ven_total as TOTAL,v.ven_pc_ref as ORDEN
	from venta as v 
	inner join usuarios as u on v.usu_id=u.usu_id
	inner join clientes as c on c.cli_id=v.cli_id
	inner join tipo_doc as td on td.td_id= v.td_id
	where c.cli_razon like '%' + @cli_razon + '%' or v.ven_correlativo like '%' + @cli_razon + '%' or v.ven_pc_ref like '%' + @cli_razon + '%'
	order by ven_correlativo desc
end






GO
/****** Object:  StoredProcedure [dbo].[caja_efectivo]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[caja_efectivo](
@idcaja int
)as begin
	select sum(cdd_abono) Efectivo
	from credito_detalle 
	where id_caja = @idcaja and tipo_pago='EFECTIVO'
end



GO
/****** Object:  StoredProcedure [dbo].[caja_gastos]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[caja_gastos](
@idcaja int
)as begin	
	select SUM(ga_total) 
	from gastos 
    where cod_caja = @idcaja
end



GO
/****** Object:  StoredProcedure [dbo].[caja_tarjeta]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[caja_tarjeta](
@idcaja int
)as begin

	select sum(cdd_abono) as tarjeta
	from credito_detalle
	where id_caja = @idcaja and tipo_pago='TARJETA'
end



GO
/****** Object:  StoredProcedure [dbo].[Cargar_Datos_Para_NOTACREDITO]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Cargar_Datos_Para_NOTACREDITO](
@var int
)as begin
	select vd.vd_id as ID,
	(select top 1 t.td_descripcion from venta as v inner join tipo_doc as t on t.td_id=v.td_id where v.ven_id=@var) as TIPO_DOC,
	v.ven_serie as SERIE, v.ven_correlativo as CORRELATIVO, v.ven_fecha as FECHA,cli_id,	
	(select top 1 t.cli_numero from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_NUM,
	(select top 1 t.cli_razon from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_NOMBRE,
	(select top 1 t.cli_direccion from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_DIREC	
	from venta_detalle as vd	
	inner join venta as v on v.ven_id=vd.ven_id
	where vd.ven_id=@var
end






GO
/****** Object:  StoredProcedure [dbo].[eliminarclientes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminarclientes](
@var varchar(10))
as begin
	delete from clientes where cli_id=@var
end







GO
/****** Object:  StoredProcedure [dbo].[eliminarconsultorio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarconsultorio]
(@c_id char(10)
)as begin
	delete from consultorio where c_id=@c_id
end









GO
/****** Object:  StoredProcedure [dbo].[eliminarespecialista]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarespecialista](
@esp_id char(5)
)as begin
	delete from especialista where esp_id=@esp_id
end









GO
/****** Object:  StoredProcedure [dbo].[eliminarproducto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminarproducto](
@id int
)as begin
	update productos set elim=0
	where id=@id
end




GO
/****** Object:  StoredProcedure [dbo].[eliminarproveedor]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarproveedor](
@prov_id char(10)
)as begin
	delete from proveedores where prov_id=@prov_id
end








GO
/****** Object:  StoredProcedure [dbo].[eliminarusuario]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarusuario](
@usu_id char(5)
)as begin
	delete from usuarios
	where usu_id=@usu_id
end








GO
/****** Object:  StoredProcedure [dbo].[generar_credito_lunas_medida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[generar_credito_lunas_medida]
as begin
	select top 1 crl_id from credito_lunas_medida order by crl_id desc
end







GO
/****** Object:  StoredProcedure [dbo].[generar_nota_id]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[generar_nota_id]
as begin
	select top 1 ns_id from Nota_Salida order by ns_id desc
end





GO
/****** Object:  StoredProcedure [dbo].[generar_Numero_nota_salida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generar_Numero_nota_salida]
as begin
	select top 1 RIGHT(ns_numero,7) from Nota_Salida order by RIGHT(ns_numero,7) desc
end






GO
/****** Object:  StoredProcedure [dbo].[generarclientes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarclientes]
as begin
	select top 1 RIGHT(cli_id,7) from clientes order by RIGHT(cli_id,7) desc
end






GO
/****** Object:  StoredProcedure [dbo].[generarcompra]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarcompra]
as begin
	select top 1 RIGHT(com_id,7) from compras order by RIGHT(com_id,7) desc
end







GO
/****** Object:  StoredProcedure [dbo].[generarcompracorrelativo]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[generarcompracorrelativo]
as begin
	select top 1 com_numerodoc from compras
end






GO
/****** Object:  StoredProcedure [dbo].[generarconsultorio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarconsultorio]
as begin
	select top 1 RIGHT(c_id,7) from consultorio order by RIGHT(c_id,7) desc
end






GO
/****** Object:  StoredProcedure [dbo].[generarcredito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarcredito]

as begin
	select top 1 cr_pccorrelativo from credito 
	--where vendedor = @vende
	order by cr_pccorrelativo DESC	
end





GO
/****** Object:  StoredProcedure [dbo].[generarespecialista]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarespecialista]
as begin
	select top 1 RIGHT(esp_id,2) from especialista order by RIGHT(esp_id,2) desc
end





GO
/****** Object:  StoredProcedure [dbo].[GenerarGiro]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GenerarGiro]
as begin
	select top 1 id from Giros 
	--where vendedor = @vende
	order by id DESC	
end
GO
/****** Object:  StoredProcedure [dbo].[generarlunas]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[generarlunas]
as begin
	select top 1 lunas_id from credito_lunas order by lunas_id DESC
end






GO
/****** Object:  StoredProcedure [dbo].[generarproveedor]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[generarproveedor]
 as begin
	select top 1 RIGHT(prov_id,6) from proveedores order by RIGHT(prov_id,6) desc
 end







GO
/****** Object:  StoredProcedure [dbo].[generarusuario]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[generarusuario]
as begin
	select top 1 RIGHT(usu_id,3) from usuarios order by RIGHT(usu_id,3) desc
end






GO
/****** Object:  StoredProcedure [dbo].[generarventa]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[generarventa]
as begin
	select top 1 ven_id from venta order by ven_id desc
end







GO
/****** Object:  StoredProcedure [dbo].[guardar_cierre_inicio_sesion]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[guardar_cierre_inicio_sesion](
@is_id int,
@fec_salida smalldatetime,
@inicio_caja decimal(10,2),
@caja_ventas decimal(10,2),
@caja_gastos decimal(10,2),
@caja_final decimal(10,2),
@caja_sobrantes decimal(10,2),
@caja_faltantes decimal(10,2)
)as begin		
	 update inicio_sesion set fec_hor_salida=@fec_salida,inicio_caja=@inicio_caja,caja_ventas=@caja_ventas,
	 caja_gastos=@caja_gastos,caja_final=@caja_final,caja_sobrantes=@caja_sobrantes,caja_faltantes=@caja_faltantes
	 where is_id=@is_id
end







GO
/****** Object:  StoredProcedure [dbo].[guardar_inicio_sesion]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[guardar_inicio_sesion](
@u_id char(5),
@fec_hor_inicio smalldatetime,
@inicio_caja decimal(10,2),
@caja_ventas decimal(10,2),
@caja_gastos decimal(10,2),
@caja_final decimal(10,2),
@vendedor varchar(3)
)as begin
	insert into inicio_sesion(u_id,fec_hor_inicio,inicio_caja,caja_ventas,caja_gastos,caja_final, vendedor_id) 
	values(@u_id,@fec_hor_inicio,@inicio_caja,@caja_ventas,@caja_gastos,@caja_final,@vendedor)
end




GO
/****** Object:  StoredProcedure [dbo].[listar]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listar]
as begin
	select prov_id as ID, prov_ruc as RUC, prov_razon as 'RAZON SOCIAL', prov_direccion as DIRECCION, prov_telefono as TELEFONO
	 from proveedores
end







GO
/****** Object:  StoredProcedure [dbo].[listar_clientes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listar_clientes]
as begin
	select	c.cli_id ID,
			c.cli_numero as DNI,
			c.cli_razon as 'NOMBRE COMPLETO',
			c.cli_ocupacion as OCUPACION,
			c.cli_sexo SEXO,
			c.cli_direccion DIRECCION,
			c.cli_telefono TELEFONO,
			c.nombre GARANTE,
			c.direccion DIRECCIONG,
			c.telefono TELEFONOG,
			c.garantia GARANTIA
	from clientes c ORDER BY cli_id DESC
end






GO
/****** Object:  StoredProcedure [dbo].[listar_filtro_convenios]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[listar_filtro_convenios] (
@vende varchar(5)
)as begin
	select * from convenios where codigo_vende = @vende
end



GO
/****** Object:  StoredProcedure [dbo].[listar_nota]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listar_nota](
@var varchar(10)
)as begin
	select nc_id as ID, nc_serie as SERIE, nc_numero as NUMERO, v2_fechaHora as FECHA, v6_numero_doc as DOCUMENT
	,v7_razon_soci as NOMBRE, v10_motivo_sustento as MOTIVO, v12_serie_numero as 'DOC REFERENCIA', v19_importe_total as TOTAL
	 from Nota_credito
end







GO
/****** Object:  StoredProcedure [dbo].[listar_nota_salida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listar_nota_salida]
as begin
	select ns_id as ID,ns_numero as CORRELATIVO, ns_fecha as FECHA, u.usu_nombre as USUARIO, motivo as MOTIVO,
		autorizado as 'AUTOIZADO POR', total as TOTAL
	from Nota_Salida
	inner join usuarios as u on u.usu_id=Nota_Salida.usu_id
	order by ns_numero desc
end





GO
/****** Object:  StoredProcedure [dbo].[listar_proveedor_lunas]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listar_proveedor_lunas]
as begin
	select pl.pl_id as ID, pl.pl_descripcion as DESCRIPCION from Proveedor_Lunas as pl
end









GO
/****** Object:  StoredProcedure [dbo].[listar_tipo]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listar_tipo]
as begin
	select * from tipo_usuario
end
----





GO
/****** Object:  StoredProcedure [dbo].[listar_vendedores]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listar_vendedores] as begin
	select * from Vendedores
end



GO
/****** Object:  StoredProcedure [dbo].[listarcompra]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarcompra](
@cod_ven varchar(50),
@var varchar(50)
)
as begin
	select c.com_id AS ID,p.prov_razon AS 'RAZON SOCIAL',c.com_tipodoc AS DOCUMENTO,c.com_numerodoc AS NUMERO,
	c.com_fecha AS FECHA,u.usu_nombre AS USUARIO from compras as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join proveedores as p on p.prov_id=c.prov_id
	where cod_vend = @cod_ven and com_numerodoc like '%' + @var + '%'
end



GO
/****** Object:  StoredProcedure [dbo].[listarcompradetalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listarcompradetalle]
as begin
	select c.cd_id,c.com_id,p.pro_descripcion,c.cd_venta,c.cd_cant from compras_detalle as c
	inner join productos as p on p.pro_id=c.pro_id
end








GO
/****** Object:  StoredProcedure [dbo].[listarcredito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarcredito]
as begin
	select c.id ID,c.cr_pccorrelativo as ORDEN,c.cr_fecha as FECHA,u.usu_nombre as PRESTAMISTA,cl.cli_razon as CLIENTES,
	c.cr_monto MONTO,
	c.cr_interes INTERES, 
	c.cr_moratotal MORA,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id

	inner join credito_detalle cd on cd.id_cr_pccorrelativo = c.id
	group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia
	order by cr_pccorrelativo desc	
end




GO
/****** Object:  StoredProcedure [dbo].[listarcreditodetalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarcreditodetalle](
@idcre int
)
as begin
	select cdd_id as ID,cdd_numero as 'N°', cdd_fecha as FECHA, cdd_abono as MONTO, cdd_saldo as RESTANTE,	
	IIF(cdd_estado = 1, 'PAGADO','-') AS ESTADO
	from credito_detalle 
	where id_cr_pccorrelativo=@idcre order by cdd_numero asc
end





GO
/****** Object:  StoredProcedure [dbo].[listarespecialista]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarespecialista]
as begin
	select esp_id as ID, esp_nombre as 'NOMBRE DEL ESPECIALISTA' from especialista
end








GO
/****** Object:  StoredProcedure [dbo].[listargasto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listargasto]
as begin
 select * from gastos
end








GO
/****** Object:  StoredProcedure [dbo].[listarproducto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarproducto]
@cod_vende varchar(3),
@fam int,
@lin int
as begin
	select id as ID, pro_id as CODIGO, pro_descripcion as DECRIPCION,
	pro_stock as STOCK, pro_precio as PRECIO, f.descripcion as FAMILIA, l.descripcion as LINEA
	from productos as p
	inner join productos_familia as f on f.id_familia=p.id_familia
	inner join productos_linea as l on l.id_linea=p.id_linea
	where p.id_familia=@fam and p.id_linea=@lin and cod_vende=@cod_vende and elim>0	
end



GO
/****** Object:  StoredProcedure [dbo].[listarproductoFamilia]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarproductoFamilia]
as begin
	select id_familia as ID, descripcion as DESCRIPCION from productos_familia
end



GO
/****** Object:  StoredProcedure [dbo].[listarproductoLinea]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listarproductoLinea]
as begin
	select id_linea as ID, descripcion as DESCRIPCION from productos_linea
end



GO
/****** Object:  StoredProcedure [dbo].[listarusuario]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarusuario]
as begin
	select u.usu_id AS ID_USUARIO,u.usu_dni,u.usu_nombre AS NOMBRES,u.usu_direccion,u.usu_telefono,u.usu_usuario,u.usu_clave,t.tipo_nombre from usuarios as u
	inner join tipo_usuario as t on t.tipo_id=u.tipo_id
end







GO
/****** Object:  StoredProcedure [dbo].[listarventa]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listarventa]
as begin
	select top (100) v.ven_id as ID,td.td_descripcion as DOC,v.ven_serie as SERIE,v.ven_correlativo as CORRELATIVO,v.ven_fecha as FECHA,
	u.usu_nombre as VENDEDOR,c.cli_razon as CLIENTE,v.ven_total as TOTAL,v.ven_pc_ref as ORDEN
	from venta as v 
	inner join usuarios as u on v.usu_id=u.usu_id
	inner join clientes as c on c.cli_id=v.cli_id
	inner join tipo_doc as td on td.td_id= v.td_id
	order by ven_correlativo desc
end







GO
/****** Object:  StoredProcedure [dbo].[registarventa]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registarventa](
@ven_id int,
@td_id varchar(7),
@ven_serie varchar(4),
@ven_correlativo varchar(7),
@ven_fecha smalldatetime,
@usu_id char(5),
@cli_id char(10),
@ven_total decimal(10,2),
@ven_pc_ref varchar(7),
@ven_ley varchar(150),
@ven_qr_code image
)as begin
	insert into venta values(@ven_id,@td_id,@ven_serie,@ven_correlativo,@ven_fecha,@usu_id,@cli_id,@ven_total,
	@ven_pc_ref,@ven_ley,@ven_qr_code)
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_convenio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrar_convenio](
@cv_codigo varchar(20),
@cv_descripcion varchar(100)
)as begin

	insert into convenios values(@cv_codigo,@cv_descripcion)
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_credito_product]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrar_credito_product](
@cr_pccorrelativo int,
@cantidad int,
@pro_id varchar(20),
@adicional varchar(100),
@adicional_precio decimal(10,2),
@precio decimal(10,2),
@subtotal decimal(10,2)
)as begin
	insert into credito_product values(@cr_pccorrelativo,@cantidad,@pro_id,@adicional, @adicional_precio,@precio,@subtotal)
end




GO
/****** Object:  StoredProcedure [dbo].[registrar_giro]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrar_giro](
@id	varchar(8)					,
@emisor_origen	varchar(50)		,
@emisor_dni	varchar(15)			,
@emisor_nombre	varchar(100)	,
@destino_origen	varchar(50)		,
@destino_dni	varchar(15)		,
@destino_nombre	varchar(100)	,
@monto_giro	decimal(10, 2)		,
@monto_comision	decimal(10, 2)	,
@codigo_retiro	char(4)
) as begin

	insert into Giros values(
			@id				,
			@emisor_origen	,
			@emisor_dni		,
			@emisor_nombre	,
			@destino_origen	,
			@destino_dni	,
			@destino_nombre	,
			@monto_giro		,
			@monto_comision	,
			@codigo_retiro	,
			GETDATE()
	)
end


GO
/****** Object:  StoredProcedure [dbo].[registrar_nota_credito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrar_nota_credito](
@nc_serie varchar(4),
@nc_numero varchar(7),
@v2_fechaHora smalldatetime,
@v5_tipo_documento varchar(5),	--1 dni 6 ruc
@v6_numero_doc varchar(20),
@v7_razon_soci varchar(150),
@v9_codigo_tipo_nota varchar(5),	--catalogo 10
@v10_motivo_sustento varchar(100),
@v11_doc_que_modifica varchar(5),		--01 fac 03 bolet
@v12_serie_numero varchar(25),
@v19_importe_total decimal(10,2),
@qr_code image,
@total_letras varchar(200),
@cli_direccion varchar(254)
)as begin
	insert into Nota_credito values(@nc_serie,@nc_numero,@v2_fechaHora,@v5_tipo_documento,@v6_numero_doc,@v7_razon_soci,@v9_codigo_tipo_nota
	,@v10_motivo_sustento,@v11_doc_que_modifica,@v12_serie_numero,@v19_importe_total,@qr_code,@total_letras,@cli_direccion)
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_nota_credito_detalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrar_nota_credito_detalle](
	@nc_id int,
	@pro_id varchar(20),
	@vd_precio decimal(10,2),
	@vd_cant decimal (10,2),
	@vd_subtotal decimal(10,2)
)as begin
	insert into Nota_credito_detalle values(@nc_id,@pro_id,@vd_precio,@vd_cant,@vd_subtotal)
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_nota_salida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrar_nota_salida](
@ns_id int,
@ns_numero varchar(8),
@ns_fecha date,
@usu_id char(5),
@motivo varchar(250),
@autorizado varchar(250),
@total decimal(10,2)
)as begin
	insert into Nota_Salida 
	values	(
				@ns_id,@ns_numero,@ns_fecha,@usu_id,@motivo,@autorizado,@total
			)
end





GO
/****** Object:  StoredProcedure [dbo].[registrar_nota_salida_detalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrar_nota_salida_detalle](
	@ns_id int,
	@cant decimal(10,2),
	@pro_id varchar(20),
	@precio decimal(10,2),
	@subtotal decimal(10,2)
)as begin
	insert into Nota_Salida_Detalle
	values	(
				@ns_id,@cant,@pro_id,@precio,@subtotal
			)
end





GO
/****** Object:  StoredProcedure [dbo].[registrarclientes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarclientes](
@cli_id varchar(10),
@cli_numero varchar(15),
@cli_razon varchar(100),
@cli_ocupacion varchar(50),
@cli_sexo varchar(5),
@cli_direccion varchar(100),
@cli_telefono varchar(9),

@nombre varchar(250),
@direccion varchar(250),
@telefono varchar(250),
@garantia varchar(250)
)as begin
	insert into clientes 
	values(@cli_id,@cli_numero,@cli_razon,@cli_ocupacion,@cli_sexo,@cli_direccion,@cli_telefono,
		@nombre,@direccion,@telefono,@garantia)
end



select * from clientes



GO
/****** Object:  StoredProcedure [dbo].[registrarcompradetalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrarcompradetalle](
@com_id char(10),
@pro_id varchar(20),
@cd_compra decimal(10,2),
@cd_venta decimal(10,2),
@cd_cant int
) as begin
	insert into compras_detalle values(@com_id,@pro_id,@cd_compra,@cd_venta,@cd_cant)
end







GO
/****** Object:  StoredProcedure [dbo].[registrarconsultorio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarconsultorio](
@cli_id char(10),
@uso_lentes2 varchar(50),
@años2 varchar(50),
@od2 varchar(50),
@oi2 varchar(50),
@addd2 varchar(50),
@dip2 varchar(50),
@recomend2 varchar(250),
@c_fecha date,
@od_esf varchar(5),
@od_cil varchar(5),
@od_eje varchar(5),
@od_dip varchar(5),
@id_esf varchar(5),
@id_cil varchar(5),
@id_eje varchar(5),
@id_dip varchar(5),
@addd varchar(20),
@pio_od5 varchar(50),
@pio_oi5 varchar(50),
@pio_od10 varchar(50),
@pio_oi10 varchar(50),
@quera_od1 varchar(50),
@quera_od2 varchar(50),
@quera_oi1 varchar(50),
@quera_io2 varchar(50),
@recomendaciones varchar(250),
@esp_id char(5)
)as begin

insert into consultorio values(@cli_id,@uso_lentes2,@años2,@od2,@oi2,@addd2,@dip2,@recomend2,
@c_fecha,@od_esf,@od_cil,@od_eje,@od_dip,@id_esf,@id_cil,@id_eje,@id_dip,@addd,
@pio_od5,@pio_oi5,@pio_od10,@pio_oi10,@quera_od1,@quera_od2,@quera_oi1,@quera_io2,
@recomendaciones,@esp_id)

end







GO
/****** Object:  StoredProcedure [dbo].[registrarcredito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarcredito](
@cr_pccorrelativo varchar(7),
@cr_fecha smalldatetime,
@usu_id char(5),
@cli_id char(10),
@cr_monto		decimal(10,2),
@cr_interes		decimal(10,2),
@cr_moratotal decimal(10,2),
@cr_total decimal(10,2),
@cv_id int,
@vendedor varchar(20),
@id_caja int
)as begin
	insert into credito 
	values(@cr_pccorrelativo,@cr_fecha,@usu_id,@cli_id,
				@cr_monto,
				@cr_interes,	
				@cr_moratotal,
				@cr_total,@cv_id,@vendedor,@id_caja,1)
end
GO
/****** Object:  StoredProcedure [dbo].[registrarcreditodetalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarcreditodetalle](
@cr_pccorrelativo int,
@cdd_numero int,
@cdd_fecha smalldatetime,
@tipo_pago varchar(10),
@cdd_abono decimal(10,2),
@cdd_saldo decimal(10,2),
@cdd_estado int,
@id_caja int
)as begin
	insert into credito_detalle(	id_cr_pccorrelativo,
									cdd_numero,
									cdd_fecha,
									cdd_fecha_pago,
									tipo_pago,
									cdd_abono,
									cdd_saldo,
									cdd_mora,
									cdd_estado,
									id_caja
									) 
	values(@cr_pccorrelativo,@cdd_numero,@cdd_fecha,null,@tipo_pago,@cdd_abono,@cdd_saldo,0,@cdd_estado,@id_caja)
end

GO
/****** Object:  StoredProcedure [dbo].[registrarespecialista]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrarespecialista](
@esp_id char(5) ,
@esp_nombre varchar(100)
)as begin
	insert into especialista values(@esp_id,@esp_nombre)
end









GO
/****** Object:  StoredProcedure [dbo].[registrargasto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrargasto](
@ga_descripcion varchar(100),
@ga_total decimal(10,2),
@ga_fecha smalldatetime,
@cod_caja int
)as begin
	insert into gastos values(@ga_descripcion,@ga_total,@ga_fecha,@cod_caja)
end







GO
/****** Object:  StoredProcedure [dbo].[registrarproductos]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarproductos](
@pro_id varchar(20),
@pro_descripcion varchar(100),
@pro_stock int,
@pro_precio decimal(10,2),
@id_familia int,
@id_linea int,
@cod_vende varchar(3)
)as begin
	insert into productos values(@pro_id,@pro_descripcion,@pro_stock,@pro_precio,1,@id_familia,@id_linea,@cod_vende)
end




GO
/****** Object:  StoredProcedure [dbo].[registrarproveedores]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrarproveedores](
@prov_id char(10),
@prov_ruc varchar(15),
@prov_razon varchar(100),
@prov_direccion varchar(100),
@prov_telefono varchar(9)
)as begin
	insert into proveedores values(@prov_id,@prov_ruc,@prov_razon,@prov_direccion,@prov_telefono)
end







GO
/****** Object:  StoredProcedure [dbo].[registrarusuario]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registrarusuario](
@usu_id char(5),
@usu_dni varchar(8),
@usu_nombre varchar(100),
@usu_direccion varchar(100),
@usu_telefono varchar(9),
@usu_usuario varchar(20),
@usu_clave varchar(20),
@tipo_id int
)as begin
	insert into usuarios values(@usu_id,@usu_dni,@usu_nombre,@usu_direccion,@usu_telefono,@usu_usuario,@usu_clave,@tipo_id)
end







GO
/****** Object:  StoredProcedure [dbo].[registrarventadetalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrarventadetalle](
@ven_id int,
@pro_id varchar(20),
@adicional varchar(50),
@vd_precio decimal(10,2),
@vd_cant int,
@vd_subtotal decimal(10,2)
)as begin
	insert into venta_detalle values(@ven_id,@pro_id,@adicional,@vd_precio,@vd_cant,@vd_subtotal)
end






GO
/****** Object:  StoredProcedure [dbo].[rpt_caja]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_caja](
@fec1 smalldatetime,
@fec2 smalldatetime,
@idapertura as int
)as begin
	declare @totalefectivo as decimal(10,2);
	declare @totaltarjeta as decimal(10,2);
	declare @totalgasto as decimal(10,2);

	SELECT @totalefectivo = ISNULL(sum(cdd_abono), 0)  FROM credito_detalle as cd
	where cd.tipo_pago='EFECTIVO' and cd.cdd_fecha>=CONVERT(smalldatetime,@fec1) and cd.cdd_fecha<=CONVERT(smalldatetime,@fec2)

	SELECT @totaltarjeta = ISNULL(sum(cdd_abono), 0) FROM credito_detalle as cd
	where cd.tipo_pago='TARJETA' and cd.cdd_fecha>=CONVERT(smalldatetime,@fec1) and cd.cdd_fecha<=CONVERT(smalldatetime,@fec2)

	select @totalgasto= ISNULL(sum(ga_total), 0)  from gastos where ga_fecha>=@fec1 and ga_fecha<=@fec2


	--inicio del select
	SELECT TOP 1 ISN.is_id AS ID,UUS.usu_nombre AS USUARIO,ISN.fec_hor_inicio AS fecAPERTURA, ISN.fec_hor_inicio AS fecCIERRE,
	ISN.inicio_caja AS MONTO_INICIO, @totalefectivo as efectivo, @totaltarjeta as tarjeta,

	@totalefectivo + @totaltarjeta AS VENTA_TOTAL,@totalgasto AS GASTOS,(@totalefectivo-@totalgasto)+ISN.inicio_caja AS CAJA_FINAL,
	caja_sobrantes AS SOBRANTES,caja_faltantes AS FALTANTES
	
	FROM inicio_sesion AS ISN
	INNER JOIN usuarios AS UUS ON UUS.usu_id=ISN.u_id	
	where isn.is_id=@idapertura
end




GO
/****** Object:  StoredProcedure [dbo].[rpt_compra_detalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_compra_detalle](
@com_id varchar(10)
)
as begin
	select c.cd_id,c.com_id,p.pro_descripcion,c.cd_compra,c.cd_venta,c.cd_cant from compras_detalle as c
	inner join productos as p on p.id=c.pro_id
	where c.com_id=@com_id
end





GO
/****** Object:  StoredProcedure [dbo].[rpt_compras]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_compras](
@fec1 date,@fec2 date
)as begin
select top 100 c.com_id as ID,p.prov_razon as PROVEEDOR,c.com_tipodoc 'TIPO DOC',c.com_numerodoc as NUMERACION,
	c.com_fecha as FECHA,u.usu_nombre as USUARIO from compras as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join proveedores as p on p.prov_id=c.prov_id
where c.com_fecha>=@fec1 and c.com_fecha<=@fec2
end







GO
/****** Object:  StoredProcedure [dbo].[rpt_comprobante]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_comprobante](
@var int
)as begin
	select vd.vd_id as ID, vd.vd_cant as CANT, p.pro_id as ID_PRO, p.pro_descripcion as DESCRIPCION,vd.adicional as ADICIONAL ,vd.vd_precio as PRECIO,vd.vd_subtotal as SUBTOTAL,
	(select top 1 t.td_descripcion from venta as v inner join tipo_doc as t on t.td_id=v.td_id where v.ven_id=@var) as TIPO_DOC,
	v.ven_serie as SERIE, v.ven_correlativo as CORRELATIVO, v.ven_fecha as FECHA,
	(select top 1 t.usu_nombre from venta as v inner join usuarios as t on t.usu_id=v.usu_id where v.ven_id=@var) as VENDEDOR,
	(select top 1 t.cli_numero from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_NUM,
	(select top 1 t.cli_razon from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_NOMBRE,
	(select top 1 t.cli_direccion from venta as v inner join clientes as t on t.cli_id=v.cli_id where v.ven_id=@var) as CLI_DIREC,
	v.ven_total as TOTAL, v.ven_pc_ref as ORDEN,v.ven_ley as LEYENDA,v.ven_qr_code as QR_CODE
	from venta_detalle as vd
	inner join productos as p on p.id=vd.pro_id
	inner join venta as v on v.ven_id=vd.ven_id
	where vd.ven_id=@var
end





GO
/****** Object:  StoredProcedure [dbo].[rpt_credito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_credito](
@fec1 date, @fec2 date
)as begin
	select c.cr_pccorrelativo AS ORDEN,c.cr_fecha AS FECHA,u.usu_nombre AS VENDEDOR,cl.cli_razon AS CLIENTE,cl.cli_telefono,
	c.cr_total AS TOTAL,(select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)as SALDO	 
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	where cr_fecha>=@fec1 and cr_fecha<=@fec2
end







GO
/****** Object:  StoredProcedure [dbo].[rpt_credito_cobros]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[rpt_credito_cobros](
@fecha1 date,
@fecha2 date
)as begin
	select cd.*, c.cr_pccorrelativo from credito_detalle cd
	inner join credito c on c.id = cd.id_cr_pccorrelativo
	where CONVERT(date, cdd_fecha_pago) between @fecha1 and @fecha2
	and c.bestado = 1
end


GO
/****** Object:  StoredProcedure [dbo].[rpt_credito_convenio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_credito_convenio](
@cv_id int,
@fec1 date, @fec2 date
)as begin
	select c.cr_pccorrelativo AS ORDEN,c.cr_fecha AS FECHA,u.usu_nombre AS VENDEDOR,cl.cli_razon AS CLIENTE,cl.cli_telefono as Telefono,
	c.cr_total AS TOTAL,(select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)as SALDO
	,cv1.cv_descripcion as DESCRIPCIONN
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	inner join convenios as cv1 on cv1.cv_id = c.cv_id
	where cr_fecha>=@fec1 and cr_fecha<=@fec2 and c.cv_id=@cv_id
end








GO
/****** Object:  StoredProcedure [dbo].[rpt_credito_deudas]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[rpt_credito_deudas]
as begin
	select c.cr_pccorrelativo AS ORDEN,c.cr_fecha AS FECHA,u.usu_nombre AS VENDEDOR,cl.cli_razon AS CLIENTE,cl.cli_telefono as TELEFONO,
	c.cr_total AS TOTAL,(select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)as SALDO	 
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	where (select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)>0
end








GO
/****** Object:  StoredProcedure [dbo].[rpt_credito_deudas_convenio]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rpt_credito_deudas_convenio](
@cv_id int
)
as begin
	select c.cr_pccorrelativo AS ORDEN,c.cr_fecha AS FECHA,u.usu_nombre AS VENDEDOR,cl.cli_razon AS CLIENTE,cl.cli_telefono as TELEFONO,
	c.cr_total AS TOTAL,(select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)as SALDO
	,cv1.cv_descripcion as DESCRIPCIONN
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	inner join convenios as cv1 on cv1.cv_id = c.cv_id
	where (select top 1 cdd_saldo from credito_detalle where cr_pccorrelativo=c.cr_pccorrelativo order by cdd_saldo asc)>0 and cv1.cv_id=@cv_id
end








GO
/****** Object:  StoredProcedure [dbo].[rpt_creditosAlDia]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[rpt_creditosAlDia]
as begin
	
	create table ##creditos(
		numero int,
		id int,
		orden varchar(20),
		fecha datetime,
		prestamista varchar(50),
		clientes varchar(100),
		monto decimal(10,2),
		interes decimal(10,2),
		mora decimal(10,2),
		total decimal(10,2),
		saldo decimal(10,2),
		garante varchar(5000),
	)

	create table #datos(
		fechaPen datetime,
		idcredito int
	)

	insert into ##creditos
	select ROW_NUMBER() OVER(ORDER BY c.id ASC) numero, c.id ID,c.cr_pccorrelativo as ORDEN,c.cr_fecha as FECHA,u.usu_nombre as PRESTAMISTA,cl.cli_razon as CLIENTES,
	c.cr_monto MONTO,
	c.cr_interes INTERES, 
	c.cr_moratotal MORA,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	inner join credito_detalle cd on cd.id_cr_pccorrelativo = c.id
	WHERE c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1)> 0 and bestado=1
	group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia
	order by cr_pccorrelativo desc
	

	declare @filas int
	declare @fechaPendiente datetime
	declare @idcredito int
	declare @num int = 1
	
	set @filas = (select COUNT(*) from ##creditos)
	while @num <=@filas
	begin
		set @fechaPendiente =	(	
									select top 1 cdd_fecha from credito_detalle 
									where id_cr_pccorrelativo = (select id from ##creditos where numero = @num) 
									and cdd_estado = 0
									order by cdd_numero
								)

		if @fechaPendiente >= GETDATE()
		begin
			insert into #datos
			select @fechaPendiente, id from ##creditos where numero = @num
		end
		set @num = @num +1
	end

	select d.idcredito CREDITO,cl.cli_numero DNI,cl.cli_razon CLIENTE, cl.cli_direccion DIRECCION  from #datos d
	inner join credito c on c.id = d.idcredito
	inner join clientes cl on cl.cli_id = c.cli_id

	drop table ##creditos
	drop table #datos
end
GO
/****** Object:  StoredProcedure [dbo].[rpt_creditosMOROSOS]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[rpt_creditosMOROSOS]
as 
begin
	
	create table ##creditos(
		numero int,
		id int,
		orden varchar(20),
		fecha datetime,
		prestamista varchar(50),
		clientes varchar(100),
		monto decimal(10,2),
		interes decimal(10,2),
		mora decimal(10,2),
		total decimal(10,2),
		saldo decimal(10,2),
		garante varchar(5000),
	)

	create table #datos(
		fechaPen datetime,
		idcredito int,
		cuotasPendientes int,
		restanteTotal decimal(10,2),
	)

	insert into ##creditos
	select ROW_NUMBER() OVER(ORDER BY c.id ASC) numero, c.id ID,c.cr_pccorrelativo as ORDEN,c.cr_fecha as FECHA,u.usu_nombre as PRESTAMISTA,cl.cli_razon as CLIENTES,
	c.cr_monto MONTO,
	c.cr_interes INTERES, 
	c.cr_moratotal MORA,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id
	inner join credito_detalle cd on cd.id_cr_pccorrelativo = c.id
	WHERE c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1)> 0 and bestado= 1
	group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia
	order by cr_pccorrelativo desc

	

	declare @filas int
	declare @numerocuotasPendiente int
	declare @RestanteTotal decimal(10,2)
	declare @fechaPendiente datetime
	declare @idcredito int
	declare @num int = 1
	
	set @filas = (select COUNT(*) from ##creditos)
	while @num <=@filas
	begin
		set @fechaPendiente =	(	
									select top 1 cdd_fecha from credito_detalle 
									where id_cr_pccorrelativo = (select id from ##creditos where numero = @num) 
									and cdd_estado = 0
									order by cdd_numero
								)
		
		set @numerocuotasPendiente =	(
											select top 1 count(cdd_id) from credito_detalle 
											where id_cr_pccorrelativo = (select id from ##creditos where numero = @num) 
											and cdd_estado = 0
										)

		set @RestanteTotal =	(	
									select 
									c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 
																	where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1)
									from credito c where c.id = (select id from ##creditos where numero = @num) 
								)

		if @fechaPendiente < GETDATE()
		begin
			insert into #datos
			select @fechaPendiente, id, @numerocuotasPendiente, @RestanteTotal from ##creditos where numero = @num
		end
		set @num = @num +1
	end

	select	d.idcredito CREDITO,cl.cli_numero DNI,cl.cli_razon CLIENTE, 
			cl.cli_telefono TELEFONO,cl.cli_direccion DIRECCION, cl.nombre GARANTE, 
			d.cuotasPendientes CUOTASPEDNIENTES  ,
			d.restanteTotal RESTANTE
	from #datos d
	inner join credito c on c.id = d.idcredito
	inner join clientes cl on cl.cli_id = c.cli_id

	drop table ##creditos
	drop table #datos
end
GO
/****** Object:  StoredProcedure [dbo].[rpt_creditosVigentes]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[rpt_creditosVigentes]
as begin
	select c.id ID,c.cr_pccorrelativo as ORDEN,c.cr_fecha as FECHA,u.usu_nombre as PRESTAMISTA,cl.cli_razon as CLIENTES,
	c.cr_monto MONTO,
	c.cr_interes INTERES, 
	c.cr_moratotal MORA,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE
	from credito as c
	inner join usuarios as u on u.usu_id=c.usu_id
	inner join clientes as cl on cl.cli_id=c.cli_id

	inner join credito_detalle cd on cd.id_cr_pccorrelativo = c.id

	WHERE c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1)> 0
	group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia
	order by cr_pccorrelativo desc	
end

GO
/****** Object:  StoredProcedure [dbo].[rpt_gasto]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_gasto](
@fec1 smalldatetime, @fec2 smalldatetime
)as begin
	select * from gastos
	where ga_fecha>=@fec1 and ga_fecha<=@fec2
end







GO
/****** Object:  StoredProcedure [dbo].[rpt_giro]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[rpt_giro] (
@fecha1 date,
@fecha2 date
)as begin
	select * from Giros where CONVERT(date, fechaHora)>= @fecha1 and CONVERT(date, fechaHora)<= @fecha2
end


GO
/****** Object:  StoredProcedure [dbo].[rpt_giro_detalle]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_giro_detalle](
@id	varchar(8)
)as begin
	select * , G.monto_giro + G.monto_comision AS total from Giros G where G.id = @id
end


GO
/****** Object:  StoredProcedure [dbo].[rpt_nota_credito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_nota_credito](
@var int
)as begin
	select ncd.vd_cant as CANT,CONCAT(p.pro_id, '-', p.pro_descripcion) as PRODUCTO, ncd.vd_precio as PRECIo, ncd.vd_subtotal as SUBTOTAL
	,nc.v2_fechaHora as FECHAHOR,nc.nc_serie as SERIE,nc.nc_numero as NUMERO,
	nc.v6_numero_doc as DNIRUC,nc.v7_razon_soci as NOMBRE, nc.cli_direccion as DIRECC,
	nc.v12_serie_numero as SER_NUM_REF,nc.v9_codigo_tipo_nota as COD_TIP_NOT, nc.v10_motivo_sustento AS SUSTENTO,
	nc.qr_code as QR, nc.total_letras as LETRAS,NC.v19_importe_total as TOTAL
	from Nota_credito_detalle as ncd
	inner join Nota_credito as nc on nc.nc_id=ncd.nc_id
	inner join productos as p on p.id= ncd.pro_id
	where nc.nc_id=@var
end





GO
/****** Object:  StoredProcedure [dbo].[rpt_nota_salida]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_nota_salida](
@ns_id int
)as begin
	select nd.ns_id as ID, nd.cant as CANT,CONCAT( p.pro_id, ' ', p.pro_descripcion) as DESCRP, nd.precio as PREC, nd.subtotal as SUBT,
		n.ns_id as ID,n.ns_numero as CORREL,n.motivo as MOTIVO, n.autorizado as AUTORIZA,n.ns_fecha as FECHA,
		n.total as TOTAL
	from Nota_Salida_Detalle as nd
	inner join Nota_Salida as n on n.ns_id=nd.ns_id
	inner join productos as p on p.id=nd.pro_id
	where n.ns_id=@ns_id
end




GO
/****** Object:  StoredProcedure [dbo].[rpt_pagodecredito]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[rpt_pagodecredito](
@var int
)as begin
	select	cd.id_cr_pccorrelativo,			
			cl.cli_razon as cliente,
			c.cr_total,
			cd.cdd_numero,
			cd.cdd_fecha,
			cd.cdd_fecha_pago,
			IIF(cd.cdd_estado = 1, cd.tipo_pago,'') as TIPOPAGO,
			cd.cdd_mora MORA,
			cdd_abono,
			cd.cdd_mora+ cd.cdd_abono TOTALPAGO,
			cd.cdd_saldo as Saldo,
			IIF(cd.cdd_estado = 1, 'REALIZADO','PENDIENTE') AS ESTADO

	from credito_detalle as cd
	inner join credito as c on c.id=cd.id_cr_pccorrelativo
	left join clientes as cl on cl.cli_id=c.cli_id
	where cd.cdd_id=@var
end
GO
/****** Object:  StoredProcedure [dbo].[rpt_pc]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_pc](
@cr_pccorrelativo int
)as begin
	select c.id ID,c.cr_pccorrelativo as ORDEN,u.usu_nombre as PRESTAMISTA,c.cr_fecha,
	isnull(cl.cli_numero,'') DNI,
	isnull(cl.cli_razon,'') as CLIENTES,
	isnull(cl.cli_direccion,'') as Direc,
	c.cr_total as TOTAL,
	c.cr_total -(select ISNULL(sum(cd2.cdd_abono),0) from credito_detalle cd2 where cd2.id_cr_pccorrelativo = c.id and cd2.cdd_estado = 1) as SALDO,
	c.cr_monto MONTO,
	c.cr_interes INTERES,
	cd.cdd_numero NU,
	cd.cdd_fecha as FECHA,
	cd.cdd_abono CUOTA,
	c.cr_moratotal MORA,
	cd.cdd_saldo as SALD2,
	iif(cd.cdd_estado = 1, 'PAGADO', '-') ESTADO,
	cl.nombre +  ' - ' + cl.garantia   GARANTE
	from credito_detalle as cd
	left join credito c on cd.id_cr_pccorrelativo = c.id
	left join usuarios as u on u.usu_id=c.usu_id
	left join clientes as cl on cl.cli_id=c.cli_id
	where c.id = @cr_pccorrelativo
	--group by id, c.cr_pccorrelativo, c.cr_fecha, u.usu_nombre, cl.cli_razon, c.cr_monto, 
	--cr_interes, cr_moratotal,cr_total, cl.nombre, cl.garantia
	order by id desc
end


GO
/****** Object:  StoredProcedure [dbo].[rpt_venta]    Script Date: 18/08/2020 21:13:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rpt_venta](
@fec1 date,
@fec2 date
)as begin
	select top (100) v.ven_id as ID,td.td_descripcion as DOC,v.ven_serie as SERIE,v.ven_correlativo as CORRELATIVO,v.ven_fecha as FECHA,
	u.usu_nombre as VENDEDOR,c.cli_razon as CLIENTE,v.ven_total as TOTAL,v.ven_pc_ref as ORDEN
	from venta as v 
	inner join usuarios as u on v.usu_id=u.usu_id
	inner join clientes as c on c.cli_id=v.cli_id
	inner join tipo_doc as td on td.td_id= v.td_id
	where ven_fecha>=@fec1 and ven_fecha<=@fec2
	order by ven_correlativo ASC
end









GO
