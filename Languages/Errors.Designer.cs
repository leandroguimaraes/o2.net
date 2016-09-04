﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace O2.Languages {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Errors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Errors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("O2.Languages.Errors", typeof(Errors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000011] Valor inválido para LADO do bloco..
        /// </summary>
        public static string BLOCK_INVALID_SIDE {
            get {
                return ResourceManager.GetString("BLOCK_INVALID_SIDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000039] Já existe um bloco cadastrado com o nome &apos;{N}&apos;. Por favor, escolha outro..
        /// </summary>
        public static string BLOCK_NAME_ERROR {
            get {
                return ResourceManager.GetString("BLOCK_NAME_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000038] Já existe um bloco cadastrado para o lado e posição informados..
        /// </summary>
        public static string BLOCK_SIDE_POSITION_ERROR {
            get {
                return ResourceManager.GetString("BLOCK_SIDE_POSITION_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000012] Não foi possível salvar a sessão do usuário..
        /// </summary>
        public static string CANNOT_CREATE_USER_SESSION {
            get {
                return ResourceManager.GetString("CANNOT_CREATE_USER_SESSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000013] Não foi possível carregar o módulo..
        /// </summary>
        public static string CANNOT_LOAD_REQUESTED_MODULE {
            get {
                return ResourceManager.GetString("CANNOT_LOAD_REQUESTED_MODULE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000057] A senha do usuário não pode ser alterada pois sysuser_id = 0..
        /// </summary>
        public static string CHANGE_PASSWORD_ERROR_SYSUSER_ID {
            get {
                return ResourceManager.GetString("CHANGE_PASSWORD_ERROR_SYSUSER_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000061] A classe {C} não possui atributo &apos;table&apos; definido..
        /// </summary>
        public static string CLASS_WITHOUT_TABLE_FIELD {
            get {
                return ResourceManager.GetString("CLASS_WITHOUT_TABLE_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000068] A collection {C} não possui atributo &apos;fk_column_name&apos; definido..
        /// </summary>
        public static string COLLECTION_WITHOUT_FK_COLUMN_NAME_FIELD {
            get {
                return ResourceManager.GetString("COLLECTION_WITHOUT_FK_COLUMN_NAME_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000055] String de conexão não encontrada: {STR}..
        /// </summary>
        public static string CONNECTION_STRING_NOT_FOUND {
            get {
                return ResourceManager.GetString("CONNECTION_STRING_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000056] Cultura não encontrada: {C}..
        /// </summary>
        public static string CULTURE_NOT_FOUND {
            get {
                return ResourceManager.GetString("CULTURE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000014] Os registros selecionados possuem as seguintes dependências que precisam ser deletadas antes de concluir esta operação:{REGS}.
        /// </summary>
        public static string DELETE_DEPENDENCIES_FIRST {
            get {
                return ResourceManager.GetString("DELETE_DEPENDENCIES_FIRST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000015] Não foi possível deletar o(s) registro(s)!.
        /// </summary>
        public static string DELETE_ERROR {
            get {
                return ResourceManager.GetString("DELETE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000017] As senhas digitadas devem ser iguais..
        /// </summary>
        public static string DISTINCT_PASSWORD {
            get {
                return ResourceManager.GetString("DISTINCT_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000016] A nova senha deve ser digitada duas vezes..
        /// </summary>
        public static string DISTINCT_PASSWORD_CHANGE {
            get {
                return ResourceManager.GetString("DISTINCT_PASSWORD_CHANGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000018] Este e-mail já está cadastrado em nossa base de dados..
        /// </summary>
        public static string EMAIL_EXIST {
            get {
                return ResourceManager.GetString("EMAIL_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string ERROR {
            get {
                return ResourceManager.GetString("ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000037] Erro em &apos;{L}&apos;: {E}.
        /// </summary>
        public static string ERROR_AT {
            get {
                return ResourceManager.GetString("ERROR_AT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000051] Erro ao executar a operação. Por favor, tente novamente..
        /// </summary>
        public static string EXECUTING_OP_ERROR_TRY_AGAIN {
            get {
                return ResourceManager.GetString("EXECUTING_OP_ERROR_TRY_AGAIN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000019] Arquivo não existe: {F}.
        /// </summary>
        public static string FILE_NOT_EXIST {
            get {
                return ResourceManager.GetString("FILE_NOT_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000020] Os seguintes valores não podem ser nulos:{NOT_NULL}.
        /// </summary>
        public static string FOLLOW_NOT_NULL {
            get {
                return ResourceManager.GetString("FOLLOW_NOT_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000064] {A} = 0 em {C}..
        /// </summary>
        public static string ID_ZERO_IN_CLASS {
            get {
                return ResourceManager.GetString("ID_ZERO_IN_CLASS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000062] Erro ao atualizar objeto. id = 0.
        /// </summary>
        public static string ID_ZERO_UPDATE_ERROR {
            get {
                return ResourceManager.GetString("ID_ZERO_UPDATE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000021] Não foi possível inserir o registro!.
        /// </summary>
        public static string INSERT_ERROR {
            get {
                return ResourceManager.GetString("INSERT_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000022] Uma nova configuração de sistema não pode ser incluída..
        /// </summary>
        public static string INSERT_NEW_CONFIG_ERROR {
            get {
                return ResourceManager.GetString("INSERT_NEW_CONFIG_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000023] Tipo de banco de dados inválido: {T}.
        /// </summary>
        public static string INVALID_DB_TYPE {
            get {
                return ResourceManager.GetString("INVALID_DB_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000040] Valor de atributo inválido: {C.F}.
        /// </summary>
        public static string INVALID_FIELD_VALUE {
            get {
                return ResourceManager.GetString("INVALID_FIELD_VALUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000024] O login possui caracteres inválidos..
        /// </summary>
        public static string INVALID_LOGIN_CHARS {
            get {
                return ResourceManager.GetString("INVALID_LOGIN_CHARS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000025] Senha inválida!.
        /// </summary>
        public static string INVALID_PASSWORD {
            get {
                return ResourceManager.GetString("INVALID_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000047] providerName = &apos;{PN}&apos; inválido em {AT}..
        /// </summary>
        public static string INVALID_PROVIDER_NAME_AT {
            get {
                return ResourceManager.GetString("INVALID_PROVIDER_NAME_AT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000026] Grupo de usuário inválido: {G}.
        /// </summary>
        public static string INVALID_USER_GROUP {
            get {
                return ResourceManager.GetString("INVALID_USER_GROUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000027] O login &apos;{L}&apos; já está cadastrado em nossa base de dados. Por favor, escolha outro..
        /// </summary>
        public static string LOGIN_EXIST {
            get {
                return ResourceManager.GetString("LOGIN_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000028] O login deve possuir entre {MIN} e {MAX} caracteres..
        /// </summary>
        public static string LOGIN_LENGTH {
            get {
                return ResourceManager.GetString("LOGIN_LENGTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000053] Não existe um campo {CF} PRIVATE. Operação {OP} cancelada..
        /// </summary>
        public static string NO_CLASS_PRIVATE_FIELD {
            get {
                return ResourceManager.GetString("NO_CLASS_PRIVATE_FIELD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000029] Nenhum registro encontrado..
        /// </summary>
        public static string NO_REGS_FOUND {
            get {
                return ResourceManager.GetString("NO_REGS_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000030] Nenhum registro selecionado..
        /// </summary>
        public static string NO_REGS_SELECTED {
            get {
                return ResourceManager.GetString("NO_REGS_SELECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000066] Nenhum profile associado ao grupo {G}..
        /// </summary>
        public static string NONE_SYSUSERPROFILE_FOR_SYSUSERGROUP {
            get {
                return ResourceManager.GetString("NONE_SYSUSERPROFILE_FOR_SYSUSERGROUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000031] Nenhuma alteração registrada..
        /// </summary>
        public static string NONE_UPDATED {
            get {
                return ResourceManager.GetString("NONE_UPDATED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000032] Operação não disponível..
        /// </summary>
        public static string OP_NOT_AVAILABLE {
            get {
                return ResourceManager.GetString("OP_NOT_AVAILABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000033] A senha deve possuir entre {MIN} e {MAX} caracteres..
        /// </summary>
        public static string PASSWORD_LENGTH_ERROR {
            get {
                return ResourceManager.GetString("PASSWORD_LENGTH_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000034] Senha atual incorreta. Não foi possível efetuar a alteração..
        /// </summary>
        public static string PRESENT_PASSWORD_ERROR {
            get {
                return ResourceManager.GetString("PRESENT_PASSWORD_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000035] Não foi possível realizar o ROLLBACK da operação de INSERT..
        /// </summary>
        public static string ROLLBACK_INSERT_ERROR {
            get {
                return ResourceManager.GetString("ROLLBACK_INSERT_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000036] Registro não encontrado!.
        /// </summary>
        public static string SELECT_ERROR {
            get {
                return ResourceManager.GetString("SELECT_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000049] Erro ao criar nova sessão..
        /// </summary>
        public static string SESSION_INSERT_ERROR {
            get {
                return ResourceManager.GetString("SESSION_INSERT_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000050] Sessão inexistente..
        /// </summary>
        public static string SESSION_UNEXISTENT {
            get {
                return ResourceManager.GetString("SESSION_UNEXISTENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000048] Erro ao atualizar a sessão..
        /// </summary>
        public static string SESSION_UPDATE_ERROR {
            get {
                return ResourceManager.GetString("SESSION_UPDATE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000069] O atributo {ATT} possui tamanho {ATT_SZ} porém o banco de dados permite o máximo de {DB_SZ}..
        /// </summary>
        public static string STRING_FIELD_BIGGER_THAN_DB_COLUMN {
            get {
                return ResourceManager.GetString("STRING_FIELD_BIGGER_THAN_DB_COLUMN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000001] Senha e/ou login incorretos!.
        /// </summary>
        public static string SYSTEM_LOGIN_ERROR {
            get {
                return ResourceManager.GetString("SYSTEM_LOGIN_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000043] &apos;sysuser_id&apos; difere dos demais em &apos;SysUserPermissionsCollection&apos; e não pôde ser incluído..
        /// </summary>
        public static string SYSUSER_PERMISSIONS_COLLECTION_DISTINCT_SYSUSER_ID {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_COLLECTION_DISTINCT_SYSUSER_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000042] &apos;module_id&apos; não definido em &apos;SysUserPermissionsCollection&apos;.
        /// </summary>
        public static string SYSUSER_PERMISSIONS_COLLECTION_MODULE_ID_NULL {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_COLLECTION_MODULE_ID_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000041] &apos;sysuser_id&apos; não definido em &apos;SysUserPermissionsCollection&apos;.
        /// </summary>
        public static string SYSUSER_PERMISSIONS_COLLECTION_SYSUSER_ID_NULL {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_COLLECTION_SYSUSER_ID_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000044] A referência para o módulo de id = {ID} em &apos;SysUserPermission&apos; não existe..
        /// </summary>
        public static string SYSUSER_PERMISSIONS_FK_MODULE_ID {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_FK_MODULE_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000045] A referência para o usuário de id = {ID} em &apos;SysUserPermission&apos; não existe..
        /// </summary>
        public static string SYSUSER_PERMISSIONS_FK_SYSUSER_ID {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_FK_SYSUSER_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000046] Erro de chave única em &apos;SysUserPermission&apos;: sysuser_id = {UID}, module_id = {MID}, key = {K}..
        /// </summary>
        public static string SYSUSER_PERMISSIONS_UK {
            get {
                return ResourceManager.GetString("SYSUSER_PERMISSIONS_UK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000058] O grupo {G} já está vinculado ao usuário..
        /// </summary>
        public static string SYSUSERGROUP_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("SYSUSERGROUP_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000063] O gupo {G} já está cadastrado no sistema..
        /// </summary>
        public static string SYSUSERGROUP_ALREADY_EXISTS_IN_DB {
            get {
                return ResourceManager.GetString("SYSUSERGROUP_ALREADY_EXISTS_IN_DB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000065] O grupo {G} não está vinculado ao usuário..
        /// </summary>
        public static string SYSUSERGROUP_NOT_FOUND_FOR_USER {
            get {
                return ResourceManager.GetString("SYSUSERGROUP_NOT_FOUND_FOR_USER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000059] A permissão de chave {K} já está vinculada ao usuário..
        /// </summary>
        public static string SYSUSERPERMISSION_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("SYSUSERPERMISSION_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000060] Permissão de chave {K} não encontrada..
        /// </summary>
        public static string SYSUSERPERMISSION_NOT_FOUND {
            get {
                return ResourceManager.GetString("SYSUSERPERMISSION_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000067] Profile {P} não encontrado para o sysuser_id = {ID}..
        /// </summary>
        public static string SYSUSERPROFILE_NOT_FOUND {
            get {
                return ResourceManager.GetString("SYSUSERPROFILE_NOT_FOUND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000002] Atributo inexistente: {A}.
        /// </summary>
        public static string UNEXISTENT_ATTRIBUTE {
            get {
                return ResourceManager.GetString("UNEXISTENT_ATTRIBUTE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000003] Bloco inexistente..
        /// </summary>
        public static string UNEXISTENT_BLOCK {
            get {
                return ResourceManager.GetString("UNEXISTENT_BLOCK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000004] Linguagem inexistente..
        /// </summary>
        public static string UNEXISTENT_LANGUAGE {
            get {
                return ResourceManager.GetString("UNEXISTENT_LANGUAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000005] Login inexistente!.
        /// </summary>
        public static string UNEXISTENT_LOGIN {
            get {
                return ResourceManager.GetString("UNEXISTENT_LOGIN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000006] Módulo inexistente..
        /// </summary>
        public static string UNEXISTENT_MODULE {
            get {
                return ResourceManager.GetString("UNEXISTENT_MODULE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000052] Tabela inexistente: {T}.
        /// </summary>
        public static string UNEXISTENT_TABLE {
            get {
                return ResourceManager.GetString("UNEXISTENT_TABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000007] Tema inexistente..
        /// </summary>
        public static string UNEXISTENT_THEME {
            get {
                return ResourceManager.GetString("UNEXISTENT_THEME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000008] Subgrupo de usuário inexistente..
        /// </summary>
        public static string UNEXISTENT_USER_SUBGROUP {
            get {
                return ResourceManager.GetString("UNEXISTENT_USER_SUBGROUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000009] Erro na atualização!.
        /// </summary>
        public static string UPDATE_ERROR {
            get {
                return ResourceManager.GetString("UPDATE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000054] Erro na atualização. ID = 0..
        /// </summary>
        public static string UPDATE_ERROR_ID_ZERO {
            get {
                return ResourceManager.GetString("UPDATE_ERROR_ID_ZERO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [00000010] Você não é um administrador do sistema..
        /// </summary>
        public static string YOURE_NOT_SYSADMIN {
            get {
                return ResourceManager.GetString("YOURE_NOT_SYSADMIN", resourceCulture);
            }
        }
    }
}